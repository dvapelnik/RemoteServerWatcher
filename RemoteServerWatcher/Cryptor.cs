using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography;

namespace RemoteServerWatcher {
    class Cryptor {
        private DataProtectionScope scope;

        public Cryptor(DataProtectionScope scope) {
            this.scope = scope;
        }

        //http://stackoverflow.com/questions/1678555/password-encryption-decryption-code-in-net

        public string Encrypt(string plainText) {
            if (plainText == null) {
                throw new ArgumentNullException("Argument is NULL");
            }
            byte[] data = Encoding.Unicode.GetBytes(plainText);
            byte[] encrypted = ProtectedData.Protect(data, null, this.scope);
            return Convert.ToBase64String(encrypted);
        }

        public string Decrypt(string cipter) {
            if (cipter == null) {
                throw new ArgumentNullException("Argumets is NULL");
            }
            byte[] data = Convert.FromBase64String(cipter);
            byte[] decrypted = ProtectedData.Unprotect(data, null, this.scope);
            return Encoding.Unicode.GetString(decrypted);
        }
    }
}
