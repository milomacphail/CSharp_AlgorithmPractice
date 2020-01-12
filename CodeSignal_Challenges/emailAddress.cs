string findEmailDomain(string address) {
    
    int last = address.LastIndexOf('@') + 1;
    
    return address.Substring(last, address.Length - last);

}
