using System;
using System.Collections.Generic;
using System.Text;
using System.Numerics;
using System.Windows.Forms;

namespace RSAEmulator
{
    public partial class Form_MainForm : Form
    {
        public static RadioButton[] SenderButtons;
        public static RadioButton[] ReceiverButtons;

        public User User_A;
        public User User_B;
        public User User_C;
        public User User_D;
        public User User_E;
        public User User_F;
        public List<User> Network;

        public User _Sender;
        public User _Receiver;

        public EncryptionOption _EncryptionOption;
        public byte[] _Message;
        public IExchangeProtocol _Cipher = null;

        public bool _SuccessfulExchange = false;

        public enum EncryptionOption
        {
            PUBLIC_KEY,
            AUTHENTICATED,
            SECURE_AUTHENTICATED,
        };

        #region Event Handlers

        public Form_MainForm()
        {
            InitializeComponent();
            
            Network = new List<User>();
            SenderButtons = new RadioButton[6] { rbAS, rbBS, rbCS, rbDS, rbES, rbFS };
            ReceiverButtons = new RadioButton[6] { rbAR, rbBR, rbCR, rbDR, rbER, rbFR };
            User_A = new User("A", 5, 1613, 73, 29);
            User_B = new User("B", 5, 1037, 73, 19);
            User_C = new User("C", 3, 971, 53, 29);
            User_D = new User("D", 3, 859, 47, 29);
            User_E = new User("E", 17, 593, 71, 19);
            User_F = new User("F", 5, 317, 67, 13);
            Network.Add(User_A);
            Network.Add(User_B);
            Network.Add(User_C);
            Network.Add(User_D);
            Network.Add(User_E);
            Network.Add(User_F);
            ShowUserManifest();            
        }

        private void ShowUserManifest()
        {
            foreach (User u in Network)
            {
                lstLog.Items.Add(u.ToString());
            }
        }

        private void txtMessage_MouseClick(object sender, EventArgs e)
        {
            if ((sender as TextBox).Text.Equals("Message..."))
                (sender as TextBox).Clear();
            else
                (sender as TextBox).SelectAll();
        }

        public void Sender_Selected(object sender, EventArgs e)
        {
            foreach(RadioButton r in SenderButtons)
            {
                if (r.Checked)
                {
                    switch (r.Text)
                    {
                        case "User A":
                            SetSender(ref User_A);
                            break;
                        case "User B":
                            SetSender(ref User_B);
                            break;
                        case "User C":
                            SetSender(ref User_C);
                            break;
                        case "User D":
                            SetSender(ref User_D);
                            break;
                        case "User E":
                            SetSender(ref User_E);
                            break;
                        case "User F":
                            SetSender(ref User_F);
                            break;
                        default:
                            break;
                    }
                    if (!VerifyValidParticipants())
                    {
                        r.Checked = false;
                        _Sender = null;
                    }
                }
            }
        }

        public void Receiver_Selected(object sender, EventArgs e)
        {
            foreach (RadioButton r in ReceiverButtons)
            {
                if (r.Checked)
                {
                    switch (r.Text)
                    {
                        case "User A":
                            SetReceiver(ref User_A);
                            break;
                        case "User B":
                            SetReceiver(ref User_B);
                            break;
                        case "User C":
                            SetReceiver(ref User_C);
                            break;
                        case "User D":
                            SetReceiver(ref User_D);
                            break;
                        case "User E":
                            SetReceiver(ref User_E);
                            break;
                        case "User F":
                            SetReceiver(ref User_F);
                            break;
                        default:
                            break;
                    }
                    if (!VerifyValidParticipants())
                    {
                        r.Checked = false;
                        _Receiver = null;
                    }
                }
            }
        }

        public void Encryption_Selected(object sender, EventArgs e)
        {
            if (rdPublic.Checked)
            {
                rdAuthenticated.Checked = false;
                rdSecAuth.Checked = false;
                _EncryptionOption = EncryptionOption.PUBLIC_KEY;
                return;
            }
            if (rdAuthenticated.Checked)
            {
                rdPublic.Checked = false;
                rdSecAuth.Checked = false;
                _EncryptionOption = EncryptionOption.AUTHENTICATED;
                return;
            }
            if (rdSecAuth.Checked)
            {
                rdAuthenticated.Checked = false;
                rdPublic.Checked = false;
                _EncryptionOption = EncryptionOption.SECURE_AUTHENTICATED;
                return;
            }
        }

        private void btnSend_Click(object sender, EventArgs e)
        {
            if (_Sender == null || _Receiver == null || String.IsNullOrEmpty(txtMessage.Text))
            {
                MessageBox.Show("Please select a Sender, Receiver, and Encryption Style, and please enter a message.", "RSA Emulator");
                return;
            }

            BigInteger eString;
            string EncryptionString = "";
            BigInteger dString;
            string DecryptionString = "";

            switch (_EncryptionOption)
            {
                case EncryptionOption.PUBLIC_KEY:
                    _Cipher = new CPublicKeyExchange(_Sender, _Receiver);
                    break;
                case EncryptionOption.AUTHENTICATED:
                    _Cipher = new CAuthenticatedExchange(_Sender, _Receiver);
                    break;
                case EncryptionOption.SECURE_AUTHENTICATED:
                    _Cipher = new CSecureAuthenticatedExchange(_Sender, _Receiver);
                    break;
                default:
                    break;
            }

            _Message = Encoding.ASCII.GetBytes(txtMessage.Text);
                
            foreach (byte b in _Message)
            {
                 double d = Convert.ToDouble(b);
                _Cipher.Encrypt(b, out eString);
                EncryptionString = EncryptionString + eString + " ";
            }
            char[] param = new char[] { ' ' };
            string[] packets = EncryptionString.Trim().Split(param);
            foreach (string p in packets)
            {
                double b = Convert.ToDouble(p.ToString());
                _Cipher.Decrypt(b, out dString);
                DecryptionString += (char)dString;
            }

            UpdateSenderData(EncryptionString.ToString());
            UpdateReceiverData(DecryptionString.ToString());

            if (DecryptionString.ToString().Equals(txtMessage.Text))
            {
                _SuccessfulExchange = true;
            }
            if(_SuccessfulExchange)
                lstLog.Items.Add(_Sender.Name + " to " + _Receiver.Name + " was successful.");
            else
                lstLog.Items.Add(_Sender.Name + " to " + _Receiver.Name + " was unsuccessful.");
            switch (_EncryptionOption)
            {
                case EncryptionOption.PUBLIC_KEY:
                    lstLog.Items.Add("SECURE TRANSMISSION");
                    break;
                case EncryptionOption.AUTHENTICATED:
                    lstLog.Items.Add("AUTHENTICATED TRANSMISSION");
                    break;
                case EncryptionOption.SECURE_AUTHENTICATED:
                    lstLog.Items.Add("SECURE-AUTHENTICATED TRANSMISSION");
                    break;
                default:
                    break;
            }
        }

        #endregion

        #region Validate Participants



        private bool VerifyValidParticipants()
        {
            if (_Receiver != null && _Sender != null)
            {
                if (_Receiver.Equals(_Sender)||_Sender.Equals(_Receiver))
                {
                    MessageBox.Show("The Receiving User cannot be the same as the Sending User!!!", "RSAEmulator");
                    return false;
                }
            }
            return true;
        }

        public void SetSender(ref User s)
        {
            _Sender = s;
        }
        public void SetReceiver(ref User r)
        {
            _Receiver = r;
        }

        public void UpdateSenderData(string Encryption)
        {
            txtSender.Text = _Sender.Name;
            txtEncrypt.Text = Encryption;
        }

        public void UpdateReceiverData(string Decryption)
        {
            txtReceiver.Text = _Receiver.Name;
            txtDecrypt.Text = Decryption;
        }

        #endregion

    }
}
