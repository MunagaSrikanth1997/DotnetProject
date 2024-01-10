namespace onlineBankingVo
{
    internal class ContactInformation
    {
        private string primaryEmail { get; set; }
        private string secondaryEmail { get; set; }
        private string primaryPhone { get; set; }
        private string secondaryPhone { get; set; }

        public ContactInformation(string primaryEmail, string secondaryEmail, string primaryPhone, string secondaryPhone)
        {
            this.primaryEmail = primaryEmail;
            this.secondaryEmail = secondaryEmail;
            this.primaryPhone = primaryPhone;
            this.secondaryPhone = secondaryPhone;
        }
        public ContactInformation setPrimaryEmail(string primaryEmail) { this.primaryEmail = primaryEmail; return this; }
        public ContactInformation setSecondaryEmail(string secondaryEmail) {  this.secondaryEmail = secondaryEmail; return this; }
        public ContactInformation setPrimaryPhone(string primaryPhone) {  this.primaryPhone = primaryPhone; return this; }
        public ContactInformation setSecondaryPhone(string secondaryPhone) {  this.secondaryPhone = secondaryPhone; return this; }
        public string getPrimaryEmail() { return primaryEmail;}
        public string getSecondaryEmail() {  return secondaryEmail;}
            public string getPrimaryPhone() {  return primaryPhone;}
        public string getSecondaryPhone() {  return secondaryPhone;}

    }
}
