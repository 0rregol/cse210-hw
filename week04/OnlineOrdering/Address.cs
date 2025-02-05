public class Address
{
   
    private string Street { get; set; }
    private string City { get; set; }
    private string StateProvince { get; set; }
    private string Country { get; set; }

    
    public Address(string street, string city, string stateProvince, string country)
    {
        Street = street;
        City = city;
        StateProvince = stateProvince;
        Country = country;
    }

    
    public bool IsInUSA()
    {
        return Country.ToLower() == "usa";
    }

    
    public string GetFullAddress()
    {
        return $"{Street}\n{City}, {StateProvince}\n{Country}";
    }
}