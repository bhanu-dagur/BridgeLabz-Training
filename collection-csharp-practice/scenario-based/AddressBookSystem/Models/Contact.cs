class Contact
{
    private string? firstName=String.Empty;
    private string lastName=String.Empty;
    private string address=String.Empty;
    private string city=String.Empty;
    private string state=String.Empty;
    private string zipCode=String.Empty;
    private string phoneNumber=String.Empty;
    private string email=String.Empty;

    public string? FirstName
    {
        get { return firstName; }
        set { firstName = value; }
    }
    public string LastName
    {
        get { return lastName; }
        set { lastName = value; }
    }
    public string Address
    {
        get { return address; }
        set { address = value; }
    }
    public string City
    {
        get { return city; }
        set { city = value; }
    }
    public string State
    {
        get { return state; }
        set { state = value; }
    }
    public string ZipCode
    {
        get { return zipCode; }
        set { zipCode = value; }
    }
    public string PhoneNumber
    {
        get { return phoneNumber; }
        set { phoneNumber = value; }
    }
    public string Email
    {
        get { return email; }
        set { email = value; }
    }
    public override bool Equals(object? obj)
    {
        // Contact other = obj as Contact;

        // if (other != null)
        // {
        //    // compare Old method
        //    //return this.Name == other.Name && this.Contacts == other.Contacts;
        // }

        if(obj is Contact other)
        {
            return FirstName.Equals(other.FirstName, StringComparison.OrdinalIgnoreCase) 
            && LastName.Equals(other.LastName, StringComparison.OrdinalIgnoreCase) 
            && PhoneNumber.Equals(other.PhoneNumber);
        }
        return false;
        // The Equals method is overridden to define logical equality between two Contact objects.
        // Instead of comparing memory references, it compares FirstName and LastName values.
        // StringComparison.OrdinalIgnoreCase is used to ignore case sensitivity.
        // This helps in detecting duplicate contacts when using methods like Contains().
        // is operator is used to check if obj is a Contact object.(belong to that class type or not)
    }

    public override int GetHashCode()
    {
        return (FirstName+LastName).ToLower().GetHashCode();
    }

    public override string ToString()
    {
        return $"{firstName} {lastName} {address} {city} {state} {zipCode} {phoneNumber} {email}";
    }
}