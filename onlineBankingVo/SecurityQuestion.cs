using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace onlineBankingVo
{
    internal class SecurityQuestion
    {
        private int questionId;
        private string questionName;
        private string questionValue;

        public SecurityQuestion(int questionId, string questionName, string questionValue)
        {
            this.questionId = questionId;
            this.questionName = questionName;
            this.questionValue = questionValue;
        }

        public SecurityQuestion setQuestionId(int questionId) {  this.questionId = questionId; return this; }
        public SecurityQuestion setQuestionName(string questionName) {  this.questionName = questionName; return this; }
        public SecurityQuestion setQuestionValue(string questionValue) {  this.questionValue = questionValue; return this; }
        public int getQuestionId() { return questionId; }
        public string getQuestionName() {  return questionName; }
        public string getQuestionValue() {  return questionValue; }
    }
}
