using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace onlineBankingVo
{
    internal class CustomerProfile
    {
        private string firstName { get; set; }
        private string lastName { get; set; }
        private string middleName { get; set; }
        private DateTime dateOfBirth { get; set; }
        private string socialSecurity { get; set; }
        private string sex { get; set; }
        private string maritalStatus { get; set; }
        private Address address { get; set; }
        private string userName { get; set; }
        private string password { get; set; }
        private DateTime lastAccessed { get; set; }
        private ContactInformation contactInformation { get; set; }
        private List<Document> documents;
        private List<SecurityQuestion> securityQuestions;
        private List<Account> accountsList;
        public List<Document> setDocuments(Document document)
        {
            if (documents==null)
            {
                documents = new List<Document>();
                documents.Add(document);
            }
            else
            {
                documents.Add(document);
            }
            return documents;
        }
        public List<Document> getDocuments() {  return documents; }

        public List<SecurityQuestion> setSecurityQuestions(SecurityQuestion securityQuestion)
        {
            if (securityQuestions == null)
            {
                securityQuestions = new List<SecurityQuestion>();
                securityQuestions.Add(securityQuestion);
            }
            else
            {
                securityQuestions.Add(securityQuestion);
            }
            return securityQuestions;
        }
        public List <SecurityQuestion> getSecurityQuestions() {  return securityQuestions; }
        public List<Account> setSecurityQuestions(Account account)
        {
            if (accountsList == null)
            {
                accountsList = new List<Account>();
                accountsList.Add(account);
            }
            else
            {
                accountsList.Add(account);
            }
            return accountsList;
        }
        public List<Account> getAccounts() { return this.accountsList; }

    }
}
