using Microsoft.Xrm.Sdk;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Webhook
{
    [DataContract]
    public class AccountLocal
    {
        [DataMember]
        public string i9_cpf_cnpj { get; set; }
        [DataMember]
        public string name { get; set; }

        public AccountLocal() { }

        public void SetAccountLocal(Entity account)
        {
            if (account.Attributes.ContainsKey("i9_cpf_cnpj"))
            {
                this.i9_cpf_cnpj = account["i9_cpf_cnpj"].ToString();
            }
            if (account.Attributes.ContainsKey("name"))
            {
                this.name = account["name"].ToString();
            }
        }
    }
}
