using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula_7_1.ContentClasses;

public class Contact
{
    private string? _companyName;

    public string? CompanyName
    {
        get => _companyName;
        set
        {
            if (value == null || string.IsNullOrEmpty(value))
            {
                throw new Exception("Company Name field can’t be empty");
            }
            _companyName = value;
        }
    }

    public string? CustomerID { get; set; }
    public string? ContactName { get; set; }
    public string? Address1 { get; set; }
    public string? Address2 { get; set; }
    public string? City { get; set; }
    public string? State { get; set; }
    public string? ZIP { get; set; }
    public string? Country { get; set; }
    public string? Tel { get; set; }
    public string? FAX { get; set; }

    public override string ToString() { return CustomerID + "   " + _companyName; }
    public Contact() : base()
    {
    }

    public Contact(string CompanyName, string LastName, string FirstName) : base()
    {
        this.ContactName = LastName + ", " + FirstName;
        this.CompanyName = CompanyName;
    }

    public Contact(string CompanyName) : base()
    {
        this.CompanyName = CompanyName;
    }
}

