using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace onlineBankingVo
{
    internal class Document
    {
        private string documentName;
        private string category;
        private string documentType;
        private byte[] content;

        public Document(string documentName, string category, string documentType, byte[] content)
        {
            this.documentName = documentName;
            this.category = category;
            this.documentType = documentType;
            this.content = content;
        }

        public Document setDocumentName(string documentName) { this.documentName = documentName; return this; }
        public Document setDocumentType(string documentType) {  this.documentType = documentType; return this;}
        public Document setContent(byte[] content) {  this.content = content; return this; }
        public Document setCategory(string category) { this.category = category; return this; }
    }
}
