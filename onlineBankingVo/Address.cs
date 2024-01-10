using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace onlineBankingVo
{
    internal class Address
    {
        private string addressType;
        private string address1;
        private string address2;
        private string city;
        private string stateProvince;
        private string zipCode;
        private string country;
        private string phone;

        public Address(string addressType, string address1, string address2, string city, string stateProvince, string zipCode, string country, string phone)
        {
            this.addressType = addressType;
            this.address1 = address1;
            this.address2 = address2;
            this.city = city;
            this.stateProvince = stateProvince;
            this.zipCode = zipCode;
            this.country = country;
            this.phone = phone;
        }

        public Address setAddressType(string addressType)
        {
            this.addressType = addressType;
            return this;
        }
        public Address setAddress1(string address1)
        {
            this.address1 = address1;
            return this;
        }
        public Address setAddress2(string address2) { this.address2 = address2;return this;}
        public Address setCity(string city) {  this.city = city; return this; } 
        public Address setStateProvince(string stateprovince) {  this.stateProvince = stateprovince; return this; }
        public Address setZipCode(string zipcode) {  this.zipCode = zipcode;return this; }
        public Address setCountry(string country) {  this.country = country; return this; } 
        public Address setPhone(string phone) {  this.phone = phone; return this; }
        public string getAddressType() {  return this.addressType; }

        public string getAddress1() { return this.address1;}
        public string getAddress2() { return this.address2;}
        public string getCity() { return this.city;}
        public string getStateProvince() {  return this.stateProvince;}
        public string getZipCode() {  return this.zipCode;}
        public string getCountry() { return this.country;}
        public string getPhone() { return this.phone;}


    }
}
