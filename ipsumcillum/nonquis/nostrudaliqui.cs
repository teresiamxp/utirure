using (RSACryptoServiceProvider rsa = new RSACryptoServiceProvider())
{
    // Get the public key
    string publicKey = rsa.ToXmlString(false);

    // Get the private key
    string privateKey = rsa.ToXmlString(true);

    // Do something with the keys
    // ...
}
