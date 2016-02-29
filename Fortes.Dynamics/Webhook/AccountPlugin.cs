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
        public string accountcategorycode { get; set; }
        [DataMember]
        public string accountclassificationcode { get; set; }
        [DataMember]
        public string accountid { get; set; }
        [DataMember]
        public string accountnumber { get; set; }
        [DataMember]
        public string accountratingcode { get; set; }
        [DataMember]
        public string address1_addressid { get; set; }
        [DataMember]
        public string address1_addresstypecode { get; set; }
        [DataMember]
        public string address1_city { get; set; }
        [DataMember]
        public string address1_composite { get; set; }
        [DataMember]
        public string address1_country { get; set; }
        [DataMember]
        public string address1_county { get; set; }
        [DataMember]
        public string address1_fax { get; set; }
        [DataMember]
        public string address1_freighttermscode { get; set; }
        [DataMember]
        public string address1_latitude { get; set; }
        [DataMember]
        public string address1_line1 { get; set; }
        [DataMember]
        public string address1_line2 { get; set; }
        [DataMember]
        public string address1_line3 { get; set; }
        [DataMember]
        public string address1_longitude { get; set; }
        [DataMember]
        public string address1_name { get; set; }
        [DataMember]
        public string address1_postalcode { get; set; }
        [DataMember]
        public string address1_postofficebox { get; set; }
        [DataMember]
        public string address1_primarycontactname { get; set; }
        [DataMember]
        public string address1_shippingmethodcode { get; set; }
        [DataMember]
        public string address1_stateorprovince { get; set; }
        [DataMember]
        public string address1_telephone1 { get; set; }
        [DataMember]
        public string address1_telephone2 { get; set; }
        [DataMember]
        public string address1_telephone3 { get; set; }
        [DataMember]
        public string address1_upszone { get; set; }
        [DataMember]
        public string address1_utcoffset { get; set; }
        [DataMember]
        public string address2_addressid { get; set; }
        [DataMember]
        public string address2_addresstypecode { get; set; }
        [DataMember]
        public string address2_city { get; set; }
        [DataMember]
        public string address2_composite { get; set; }
        [DataMember]
        public string address2_country { get; set; }
        [DataMember]
        public string address2_county { get; set; }
        [DataMember]
        public string address2_fax { get; set; }
        [DataMember]
        public string address2_freighttermscode { get; set; }
        [DataMember]
        public string address2_latitude { get; set; }
        [DataMember]
        public string address2_line1 { get; set; }
        [DataMember]
        public string address2_line2 { get; set; }
        [DataMember]
        public string address2_line3 { get; set; }
        [DataMember]
        public string address2_longitude { get; set; }
        [DataMember]
        public string address2_name { get; set; }
        [DataMember]
        public string address2_postalcode { get; set; }
        [DataMember]
        public string address2_postofficebox { get; set; }
        [DataMember]
        public string address2_primarycontactname { get; set; }
        [DataMember]
        public string address2_shippingmethodcode { get; set; }
        [DataMember]
        public string address2_stateorprovince { get; set; }
        [DataMember]
        public string address2_telephone1 { get; set; }
        [DataMember]
        public string address2_telephone2 { get; set; }
        [DataMember]
        public string address2_telephone3 { get; set; }
        [DataMember]
        public string address2_upszone { get; set; }
        [DataMember]
        public string address2_utcoffset { get; set; }
        [DataMember]
        public string aging30 { get; set; }
        [DataMember]
        public string aging30_base { get; set; }
        [DataMember]
        public string aging60 { get; set; }
        [DataMember]
        public string aging60_base { get; set; }
        [DataMember]
        public string aging90 { get; set; }
        [DataMember]
        public string aging90_base { get; set; }
        [DataMember]
        public string businesstypecode { get; set; }
        [DataMember]
        public string createdby { get; set; }
        [DataMember]
        public string createdon { get; set; }
        [DataMember]
        public string createdonbehalfby { get; set; }
        [DataMember]
        public string creditlimit { get; set; }
        [DataMember]
        public string creditlimit_base { get; set; }
        [DataMember]
        public string creditonhold { get; set; }
        [DataMember]
        public string customersizecode { get; set; }
        [DataMember]
        public string customertypecode { get; set; }
        [DataMember]
        public string defaultpricelevelid { get; set; }
        [DataMember]
        public string description { get; set; }
        [DataMember]
        public string donotbulkemail { get; set; }
        [DataMember]
        public string donotbulkpostalmail { get; set; }
        [DataMember]
        public string donotemail { get; set; }
        [DataMember]
        public string donotfax { get; set; }
        [DataMember]
        public string donotphone { get; set; }
        [DataMember]
        public string donotpostalmail { get; set; }
        [DataMember]
        public string donotsendmm { get; set; }
        [DataMember]
        public string emailaddress1 { get; set; }
        [DataMember]
        public string emailaddress2 { get; set; }
        [DataMember]
        public string emailaddress3 { get; set; }
        [DataMember]
        public string entityimage { get; set; }
        [DataMember]
        public string exchangerate { get; set; }
        [DataMember]
        public string fax { get; set; }
        [DataMember]
        public string ftpsiteurl { get; set; }
        [DataMember]
        public string i9_aliquota { get; set; }
        [DataMember]
        public string i9_bloquear_atendimento_cliente { get; set; }
        [DataMember]
        public string i9_bloquear_conta { get; set; }
        [DataMember]
        public string i9_bloqueia_licenca_uso_cliente { get; set; }
        [DataMember]
        public string i9_celular_aux { get; set; }
        [DataMember]
        public string i9_cidade { get; set; }
        [DataMember]
        public string i9_cliente_pagador { get; set; }
        [DataMember]
        public string i9_cliente_pagador_centraliza_hrs { get; set; }
        [DataMember]
        public string i9_cobranca_impressa { get; set; }
        [DataMember]
        public string i9_cofins { get; set; }
        [DataMember]
        public string i9_conta_contabil { get; set; }
        [DataMember]
        public string i9_cpf_cnpj { get; set; }
        [DataMember]
        public string i9_cpf_cnpj_aux { get; set; }
        [DataMember]
        public string i9_csll { get; set; }
        [DataMember]
        public string i9_ddd_celular { get; set; }
        [DataMember]
        public string i9_ddd_fax { get; set; }
        [DataMember]
        public string i9_dddfone2 { get; set; }
        [DataMember]
        public string i9_documento_estrangeiro { get; set; }
        [DataMember]
        public string i9_estado { get; set; }
        [DataMember]
        public string i9_etiqueta { get; set; }
        [DataMember]
        public string i9_exterior { get; set; }
        [DataMember]
        public string i9_fax_aux { get; set; }
        [DataMember]
        public string i9_gerar_nf_automatica { get; set; }
        [DataMember]
        public string i9_grupo { get; set; }
        [DataMember]
        public string i9_indicador_inscricao_estadual_destinatario { get; set; }
        [DataMember]
        public string i9_inscricao_estadual { get; set; }
        [DataMember]
        public string i9_inscricao_municipal { get; set; }
        [DataMember]
        public string i9_irrf { get; set; }
        [DataMember]
        public string i9_isento_inscricao { get; set; }
        [DataMember]
        public string i9_nao_cobra_atendimento_telefonico { get; set; }
        [DataMember]
        public string i9_nome_fantasia { get; set; }
        [DataMember]
        public string i9_observacao { get; set; }
        [DataMember]
        public string i9_observacao_atendimento { get; set; }
        [DataMember]
        public string i9_pais { get; set; }
        [DataMember]
        public string i9_pis { get; set; }
        [DataMember]
        public string i9_receita { get; set; }
        [DataMember]
        public string i9_retem_inss { get; set; }
        [DataMember]
        public string i9_retem_iss { get; set; }
        [DataMember]
        public string i9_rg { get; set; }
        [DataMember]
        public string i9_telephone1_aux { get; set; }
        [DataMember]
        public string i9_transportadora { get; set; }
        [DataMember]
        public string i9_utilizar_rg_como_cnpj { get; set; }
        [DataMember]
        public string importsequencenumber { get; set; }
        [DataMember]
        public string industrycode { get; set; }
        [DataMember]
        public string lastusedincampaign { get; set; }
        [DataMember]
        public string marketcap { get; set; }
        [DataMember]
        public string marketcap_base { get; set; }
        [DataMember]
        public string masterid { get; set; }
        [DataMember]
        public string merged { get; set; }
        [DataMember]
        public string modifiedby { get; set; }
        [DataMember]
        public string modifiedon { get; set; }
        [DataMember]
        public string modifiedonbehalfby { get; set; }
        [DataMember]
        public string name { get; set; }
        [DataMember]
        public string new_cli_pagador { get; set; }
        [DataMember]
        public string new_contato { get; set; }
        [DataMember]
        public string new_contatoid { get; set; }
        [DataMember]
        public string new_pai_codigo { get; set; }
        [DataMember]
        public string new_pk_codigo { get; set; }
        [DataMember]
        public string new_pk_emp_codigo { get; set; }
        [DataMember]
        public string new_representante_codigo { get; set; }
        [DataMember]
        public string new_telefonecomercial { get; set; }
        [DataMember]
        public string numberofemployees { get; set; }
        [DataMember]
        public string opendeals { get; set; }
        [DataMember]
        public string openrevenue { get; set; }
        [DataMember]
        public string openrevenue_base { get; set; }
        [DataMember]
        public string originatingleadid { get; set; }
        [DataMember]
        public string overriddencreatedon { get; set; }
        [DataMember]
        public string ownerid { get; set; }
        [DataMember]
        public string ownershipcode { get; set; }
        [DataMember]
        public string owningbusinessunit { get; set; }
        [DataMember]
        public string owningteam { get; set; }
        [DataMember]
        public string owninguser { get; set; }
        [DataMember]
        public string parentaccountid { get; set; }
        [DataMember]
        public string participatesinworkflow { get; set; }
        [DataMember]
        public string paymenttermscode { get; set; }
        [DataMember]
        public string preferredappointmentdaycode { get; set; }
        [DataMember]
        public string preferredappointmenttimecode { get; set; }
        [DataMember]
        public string preferredcontactmethodcode { get; set; }
        [DataMember]
        public string preferredequipmentid { get; set; }
        [DataMember]
        public string preferredserviceid { get; set; }
        [DataMember]
        public string preferredsystemuserid { get; set; }
        [DataMember]
        public string primarycontactid { get; set; }
        [DataMember]
        public string processid { get; set; }
        [DataMember]
        public string revenue { get; set; }
        [DataMember]
        public string revenue_base { get; set; }
        [DataMember]
        public string sharesoutstanding { get; set; }
        [DataMember]
        public string shippingmethodcode { get; set; }
        [DataMember]
        public string sic { get; set; }
        [DataMember]
        public string stageid { get; set; }
        [DataMember]
        public string statecode { get; set; }
        [DataMember]
        public string statuscode { get; set; }
        [DataMember]
        public string stockexchange { get; set; }
        [DataMember]
        public string telephone1 { get; set; }
        [DataMember]
        public string telephone2 { get; set; }
        [DataMember]
        public string telephone3 { get; set; }
        [DataMember]
        public string territorycode { get; set; }
        [DataMember]
        public string territoryid { get; set; }
        [DataMember]
        public string tickersymbol { get; set; }
        [DataMember]
        public string timezoneruleversionnumber { get; set; }
        [DataMember]
        public string transactioncurrencyid { get; set; }
        [DataMember]
        public string traversedpath { get; set; }
        [DataMember]
        public string utcconversiontimezonecode { get; set; }
        [DataMember]
        public string versionnumber { get; set; }
        [DataMember]
        public string websiteurl { get; set; }
        [DataMember]
        public string yominame { get; set; }

        public AccountLocal() { }

        public void SetAccountLocal(Entity account)
        {
            if (account.Attributes.ContainsKey("accountcategorycode"))
            {
                this.accountcategorycode = GetValueAttribute(account["accountcategorycode"]);
            }
            if (account.Attributes.ContainsKey("accountclassificationcode"))
            {
                this.accountclassificationcode = GetValueAttribute(account["accountclassificationcode"]);
            }
            if (account.Attributes.ContainsKey("accountid"))
            {
                this.accountid = GetValueAttribute(account["accountid"]);
            }
            if (account.Attributes.ContainsKey("accountnumber"))
            {
                this.accountnumber = GetValueAttribute(account["accountnumber"]);
            }
            if (account.Attributes.ContainsKey("accountratingcode"))
            {
                this.accountratingcode = GetValueAttribute(account["accountratingcode"]);
            }
            if (account.Attributes.ContainsKey("address1_addressid"))
            {
                this.address1_addressid = GetValueAttribute(account["address1_addressid"]);
            }
            if (account.Attributes.ContainsKey("address1_addresstypecode"))
            {
                this.address1_addresstypecode = GetValueAttribute(account["address1_addresstypecode"]);
            }
            if (account.Attributes.ContainsKey("address1_city"))
            {
                this.address1_city = GetValueAttribute(account["address1_city"]);
            }
            if (account.Attributes.ContainsKey("address1_composite"))
            {
                this.address1_composite = GetValueAttribute(account["address1_composite"]);
            }
            if (account.Attributes.ContainsKey("address1_country"))
            {
                this.address1_country = GetValueAttribute(account["address1_country"]);
            }
            if (account.Attributes.ContainsKey("address1_county"))
            {
                this.address1_county = GetValueAttribute(account["address1_county"]);
            }
            if (account.Attributes.ContainsKey("address1_fax"))
            {
                this.address1_fax = GetValueAttribute(account["address1_fax"]);
            }
            if (account.Attributes.ContainsKey("address1_freighttermscode"))
            {
                this.address1_freighttermscode = GetValueAttribute(account["address1_freighttermscode"]);
            }
            if (account.Attributes.ContainsKey("address1_latitude"))
            {
                this.address1_latitude = GetValueAttribute(account["address1_latitude"]);
            }
            if (account.Attributes.ContainsKey("address1_line1"))
            {
                this.address1_line1 = GetValueAttribute(account["address1_line1"]);
            }
            if (account.Attributes.ContainsKey("address1_line2"))
            {
                this.address1_line2 = GetValueAttribute(account["address1_line2"]);
            }
            if (account.Attributes.ContainsKey("address1_line3"))
            {
                this.address1_line3 = GetValueAttribute(account["address1_line3"]);
            }
            if (account.Attributes.ContainsKey("address1_longitude"))
            {
                this.address1_longitude = GetValueAttribute(account["address1_longitude"]);
            }
            if (account.Attributes.ContainsKey("address1_name"))
            {
                this.address1_name = GetValueAttribute(account["address1_name"]);
            }
            if (account.Attributes.ContainsKey("address1_postalcode"))
            {
                this.address1_postalcode = GetValueAttribute(account["address1_postalcode"]);
            }
            if (account.Attributes.ContainsKey("address1_postofficebox"))
            {
                this.address1_postofficebox = GetValueAttribute(account["address1_postofficebox"]);
            }
            if (account.Attributes.ContainsKey("address1_primarycontactname"))
            {
                this.address1_primarycontactname = GetValueAttribute(account["address1_primarycontactname"]);
            }
            if (account.Attributes.ContainsKey("address1_shippingmethodcode"))
            {
                this.address1_shippingmethodcode = GetValueAttribute(account["address1_shippingmethodcode"]);
            }
            if (account.Attributes.ContainsKey("address1_stateorprovince"))
            {
                this.address1_stateorprovince = GetValueAttribute(account["address1_stateorprovince"]);
            }
            if (account.Attributes.ContainsKey("address1_telephone1"))
            {
                this.address1_telephone1 = GetValueAttribute(account["address1_telephone1"]);
            }
            if (account.Attributes.ContainsKey("address1_telephone2"))
            {
                this.address1_telephone2 = GetValueAttribute(account["address1_telephone2"]);
            }
            if (account.Attributes.ContainsKey("address1_telephone3"))
            {
                this.address1_telephone3 = GetValueAttribute(account["address1_telephone3"]);
            }
            if (account.Attributes.ContainsKey("address1_upszone"))
            {
                this.address1_upszone = GetValueAttribute(account["address1_upszone"]);
            }
            if (account.Attributes.ContainsKey("address1_utcoffset"))
            {
                this.address1_utcoffset = GetValueAttribute(account["address1_utcoffset"]);
            }
            if (account.Attributes.ContainsKey("address2_addressid"))
            {
                this.address2_addressid = GetValueAttribute(account["address2_addressid"]);
            }
            if (account.Attributes.ContainsKey("address2_addresstypecode"))
            {
                this.address2_addresstypecode = GetValueAttribute(account["address2_addresstypecode"]);
            }
            if (account.Attributes.ContainsKey("address2_city"))
            {
                this.address2_city = GetValueAttribute(account["address2_city"]);
            }
            if (account.Attributes.ContainsKey("address2_composite"))
            {
                this.address2_composite = GetValueAttribute(account["address2_composite"]);
            }
            if (account.Attributes.ContainsKey("address2_country"))
            {
                this.address2_country = GetValueAttribute(account["address2_country"]);
            }
            if (account.Attributes.ContainsKey("address2_county"))
            {
                this.address2_county = GetValueAttribute(account["address2_county"]);
            }
            if (account.Attributes.ContainsKey("address2_fax"))
            {
                this.address2_fax = GetValueAttribute(account["address2_fax"]);
            }
            if (account.Attributes.ContainsKey("address2_freighttermscode"))
            {
                this.address2_freighttermscode = GetValueAttribute(account["address2_freighttermscode"]);
            }
            if (account.Attributes.ContainsKey("address2_latitude"))
            {
                this.address2_latitude = GetValueAttribute(account["address2_latitude"]);
            }
            if (account.Attributes.ContainsKey("address2_line1"))
            {
                this.address2_line1 = GetValueAttribute(account["address2_line1"]);
            }
            if (account.Attributes.ContainsKey("address2_line2"))
            {
                this.address2_line2 = GetValueAttribute(account["address2_line2"]);
            }
            if (account.Attributes.ContainsKey("address2_line3"))
            {
                this.address2_line3 = GetValueAttribute(account["address2_line3"]);
            }
            if (account.Attributes.ContainsKey("address2_longitude"))
            {
                this.address2_longitude = GetValueAttribute(account["address2_longitude"]);
            }
            if (account.Attributes.ContainsKey("address2_name"))
            {
                this.address2_name = GetValueAttribute(account["address2_name"]);
            }
            if (account.Attributes.ContainsKey("address2_postalcode"))
            {
                this.address2_postalcode = GetValueAttribute(account["address2_postalcode"]);
            }
            if (account.Attributes.ContainsKey("address2_postofficebox"))
            {
                this.address2_postofficebox = GetValueAttribute(account["address2_postofficebox"]);
            }
            if (account.Attributes.ContainsKey("address2_primarycontactname"))
            {
                this.address2_primarycontactname = GetValueAttribute(account["address2_primarycontactname"]);
            }
            if (account.Attributes.ContainsKey("address2_shippingmethodcode"))
            {
                this.address2_shippingmethodcode = GetValueAttribute(account["address2_shippingmethodcode"]);
            }
            if (account.Attributes.ContainsKey("address2_stateorprovince"))
            {
                this.address2_stateorprovince = GetValueAttribute(account["address2_stateorprovince"]);
            }
            if (account.Attributes.ContainsKey("address2_telephone1"))
            {
                this.address2_telephone1 = GetValueAttribute(account["address2_telephone1"]);
            }
            if (account.Attributes.ContainsKey("address2_telephone2"))
            {
                this.address2_telephone2 = GetValueAttribute(account["address2_telephone2"]);
            }
            if (account.Attributes.ContainsKey("address2_telephone3"))
            {
                this.address2_telephone3 = GetValueAttribute(account["address2_telephone3"]);
            }
            if (account.Attributes.ContainsKey("address2_upszone"))
            {
                this.address2_upszone = GetValueAttribute(account["address2_upszone"]);
            }
            if (account.Attributes.ContainsKey("address2_utcoffset"))
            {
                this.address2_utcoffset = GetValueAttribute(account["address2_utcoffset"]);
            }
            if (account.Attributes.ContainsKey("aging30"))
            {
                this.aging30 = GetValueAttribute(account["aging30"]);
            }
            if (account.Attributes.ContainsKey("aging30_base"))
            {
                this.aging30_base = GetValueAttribute(account["aging30_base"]);
            }
            if (account.Attributes.ContainsKey("aging60"))
            {
                this.aging60 = GetValueAttribute(account["aging60"]);
            }
            if (account.Attributes.ContainsKey("aging60_base"))
            {
                this.aging60_base = GetValueAttribute(account["aging60_base"]);
            }
            if (account.Attributes.ContainsKey("aging90"))
            {
                this.aging90 = GetValueAttribute(account["aging90"]);
            }
            if (account.Attributes.ContainsKey("aging90_base"))
            {
                this.aging90_base = GetValueAttribute(account["aging90_base"]);
            }
            if (account.Attributes.ContainsKey("businesstypecode"))
            {
                this.businesstypecode = GetValueAttribute(account["businesstypecode"]);
            }
            if (account.Attributes.ContainsKey("createdby"))
            {
                this.createdby = GetValueAttribute(account["createdby"]);
            }
            if (account.Attributes.ContainsKey("createdon"))
            {
                this.createdon = GetValueAttribute(account["createdon"]);
            }
            if (account.Attributes.ContainsKey("createdonbehalfby"))
            {
                this.createdonbehalfby = GetValueAttribute(account["createdonbehalfby"]);
            }
            if (account.Attributes.ContainsKey("creditlimit"))
            {
                this.creditlimit = GetValueAttribute(account["creditlimit"]);
            }
            if (account.Attributes.ContainsKey("creditlimit_base"))
            {
                this.creditlimit_base = GetValueAttribute(account["creditlimit_base"]);
            }
            if (account.Attributes.ContainsKey("creditonhold"))
            {
                this.creditonhold = GetValueAttribute(account["creditonhold"]);
            }
            if (account.Attributes.ContainsKey("customersizecode"))
            {
                this.customersizecode = GetValueAttribute(account["customersizecode"]);
            }
            if (account.Attributes.ContainsKey("customertypecode"))
            {
                this.customertypecode = GetValueAttribute(account["customertypecode"]);
            }
            if (account.Attributes.ContainsKey("defaultpricelevelid"))
            {
                this.defaultpricelevelid = GetValueAttribute(account["defaultpricelevelid"]);
            }
            if (account.Attributes.ContainsKey("description"))
            {
                this.description = GetValueAttribute(account["description"]);
            }
            if (account.Attributes.ContainsKey("donotbulkemail"))
            {
                this.donotbulkemail = GetValueAttribute(account["donotbulkemail"]);
            }
            if (account.Attributes.ContainsKey("donotbulkpostalmail"))
            {
                this.donotbulkpostalmail = GetValueAttribute(account["donotbulkpostalmail"]);
            }
            if (account.Attributes.ContainsKey("donotemail"))
            {
                this.donotemail = GetValueAttribute(account["donotemail"]);
            }
            if (account.Attributes.ContainsKey("donotfax"))
            {
                this.donotfax = GetValueAttribute(account["donotfax"]);
            }
            if (account.Attributes.ContainsKey("donotphone"))
            {
                this.donotphone = GetValueAttribute(account["donotphone"]);
            }
            if (account.Attributes.ContainsKey("donotpostalmail"))
            {
                this.donotpostalmail = GetValueAttribute(account["donotpostalmail"]);
            }
            if (account.Attributes.ContainsKey("donotsendmm"))
            {
                this.donotsendmm = GetValueAttribute(account["donotsendmm"]);
            }
            if (account.Attributes.ContainsKey("emailaddress1"))
            {
                this.emailaddress1 = GetValueAttribute(account["emailaddress1"]);
            }
            if (account.Attributes.ContainsKey("emailaddress2"))
            {
                this.emailaddress2 = GetValueAttribute(account["emailaddress2"]);
            }
            if (account.Attributes.ContainsKey("emailaddress3"))
            {
                this.emailaddress3 = GetValueAttribute(account["emailaddress3"]);
            }
            if (account.Attributes.ContainsKey("entityimage"))
            {
                this.entityimage = GetValueAttribute(account["entityimage"]);
            }
            if (account.Attributes.ContainsKey("exchangerate"))
            {
                this.exchangerate = GetValueAttribute(account["exchangerate"]);
            }
            if (account.Attributes.ContainsKey("fax"))
            {
                this.fax = GetValueAttribute(account["fax"]);
            }
            if (account.Attributes.ContainsKey("ftpsiteurl"))
            {
                this.ftpsiteurl = GetValueAttribute(account["ftpsiteurl"]);
            }
            if (account.Attributes.ContainsKey("i9_aliquota"))
            {
                this.i9_aliquota = GetValueAttribute(account["i9_aliquota"]);
            }
            if (account.Attributes.ContainsKey("i9_bloquear_atendimento_cliente"))
            {
                this.i9_bloquear_atendimento_cliente = GetValueAttribute(account["i9_bloquear_atendimento_cliente"]);
            }
            if (account.Attributes.ContainsKey("i9_bloquear_conta"))
            {
                this.i9_bloquear_conta = GetValueAttribute(account["i9_bloquear_conta"]);
            }
            if (account.Attributes.ContainsKey("i9_bloqueia_licenca_uso_cliente"))
            {
                this.i9_bloqueia_licenca_uso_cliente = GetValueAttribute(account["i9_bloqueia_licenca_uso_cliente"]);
            }
            if (account.Attributes.ContainsKey("i9_celular_aux"))
            {
                this.i9_celular_aux = GetValueAttribute(account["i9_celular_aux"]);
            }
            if (account.Attributes.ContainsKey("i9_cidade"))
            {
                this.i9_cidade = GetValueAttribute(account["i9_cidade"]);
            }
            if (account.Attributes.ContainsKey("i9_cliente_pagador"))
            {
                this.i9_cliente_pagador = GetValueAttribute(account["i9_cliente_pagador"]);
            }
            if (account.Attributes.ContainsKey("i9_cliente_pagador_centraliza_hrs"))
            {
                this.i9_cliente_pagador_centraliza_hrs = GetValueAttribute(account["i9_cliente_pagador_centraliza_hrs"]);
            }
            if (account.Attributes.ContainsKey("i9_cobranca_impressa"))
            {
                this.i9_cobranca_impressa = GetValueAttribute(account["i9_cobranca_impressa"]);
            }
            if (account.Attributes.ContainsKey("i9_cofins"))
            {
                this.i9_cofins = GetValueAttribute(account["i9_cofins"]);
            }
            if (account.Attributes.ContainsKey("i9_conta_contabil"))
            {
                this.i9_conta_contabil = GetValueAttribute(account["i9_conta_contabil"]);
            }
            if (account.Attributes.ContainsKey("i9_cpf_cnpj"))
            {
                this.i9_cpf_cnpj = GetValueAttribute(account["i9_cpf_cnpj"]);
            }
            if (account.Attributes.ContainsKey("i9_cpf_cnpj_aux"))
            {
                this.i9_cpf_cnpj_aux = GetValueAttribute(account["i9_cpf_cnpj_aux"]);
            }
            if (account.Attributes.ContainsKey("i9_csll"))
            {
                this.i9_csll = GetValueAttribute(account["i9_csll"]);
            }
            if (account.Attributes.ContainsKey("i9_ddd_celular"))
            {
                this.i9_ddd_celular = GetValueAttribute(account["i9_ddd_celular"]);
            }
            if (account.Attributes.ContainsKey("i9_ddd_fax"))
            {
                this.i9_ddd_fax = GetValueAttribute(account["i9_ddd_fax"]);
            }
            if (account.Attributes.ContainsKey("i9_dddfone2"))
            {
                this.i9_dddfone2 = GetValueAttribute(account["i9_dddfone2"]);
            }
            if (account.Attributes.ContainsKey("i9_documento_estrangeiro"))
            {
                this.i9_documento_estrangeiro = GetValueAttribute(account["i9_documento_estrangeiro"]);
            }
            if (account.Attributes.ContainsKey("i9_estado"))
            {
                this.i9_estado = GetValueAttribute(account["i9_estado"]);
            }
            if (account.Attributes.ContainsKey("i9_etiqueta"))
            {
                this.i9_etiqueta = GetValueAttribute(account["i9_etiqueta"]);
            }
            if (account.Attributes.ContainsKey("i9_exterior"))
            {
                this.i9_exterior = GetValueAttribute(account["i9_exterior"]);
            }
            if (account.Attributes.ContainsKey("i9_fax_aux"))
            {
                this.i9_fax_aux = GetValueAttribute(account["i9_fax_aux"]);
            }
            if (account.Attributes.ContainsKey("i9_gerar_nf_automatica"))
            {
                this.i9_gerar_nf_automatica = GetValueAttribute(account["i9_gerar_nf_automatica"]);
            }
            if (account.Attributes.ContainsKey("i9_grupo"))
            {
                this.i9_grupo = GetValueAttribute(account["i9_grupo"]);
            }
            if (account.Attributes.ContainsKey("i9_indicador_inscricao_estadual_destinatario"))
            {
                this.i9_indicador_inscricao_estadual_destinatario = GetValueAttribute(account["i9_indicador_inscricao_estadual_destinatario"]);
            }
            if (account.Attributes.ContainsKey("i9_inscricao_estadual"))
            {
                this.i9_inscricao_estadual = GetValueAttribute(account["i9_inscricao_estadual"]);
            }
            if (account.Attributes.ContainsKey("i9_inscricao_municipal"))
            {
                this.i9_inscricao_municipal = GetValueAttribute(account["i9_inscricao_municipal"]);
            }
            if (account.Attributes.ContainsKey("i9_irrf"))
            {
                this.i9_irrf = GetValueAttribute(account["i9_irrf"]);
            }
            if (account.Attributes.ContainsKey("i9_isento_inscricao"))
            {
                this.i9_isento_inscricao = GetValueAttribute(account["i9_isento_inscricao"]);
            }
            if (account.Attributes.ContainsKey("i9_nao_cobra_atendimento_telefonico"))
            {
                this.i9_nao_cobra_atendimento_telefonico = GetValueAttribute(account["i9_nao_cobra_atendimento_telefonico"]);
            }
            if (account.Attributes.ContainsKey("i9_nome_fantasia"))
            {
                this.i9_nome_fantasia = GetValueAttribute(account["i9_nome_fantasia"]);
            }
            if (account.Attributes.ContainsKey("i9_observacao"))
            {
                this.i9_observacao = GetValueAttribute(account["i9_observacao"]);
            }
            if (account.Attributes.ContainsKey("i9_observacao_atendimento"))
            {
                this.i9_observacao_atendimento = GetValueAttribute(account["i9_observacao_atendimento"]);
            }
            if (account.Attributes.ContainsKey("i9_pais"))
            {
                this.i9_pais = GetValueAttribute(account["i9_pais"]);
            }
            if (account.Attributes.ContainsKey("i9_pis"))
            {
                this.i9_pis = GetValueAttribute(account["i9_pis"]);
            }
            if (account.Attributes.ContainsKey("i9_receita"))
            {
                this.i9_receita = GetValueAttribute(account["i9_receita"]);
            }
            if (account.Attributes.ContainsKey("i9_retem_inss"))
            {
                this.i9_retem_inss = GetValueAttribute(account["i9_retem_inss"]);
            }
            if (account.Attributes.ContainsKey("i9_retem_iss"))
            {
                this.i9_retem_iss = GetValueAttribute(account["i9_retem_iss"]);
            }
            if (account.Attributes.ContainsKey("i9_rg"))
            {
                this.i9_rg = GetValueAttribute(account["i9_rg"]);
            }
            if (account.Attributes.ContainsKey("i9_telephone1_aux"))
            {
                this.i9_telephone1_aux = GetValueAttribute(account["i9_telephone1_aux"]);
            }
            if (account.Attributes.ContainsKey("i9_transportadora"))
            {
                this.i9_transportadora = GetValueAttribute(account["i9_transportadora"]);
            }
            if (account.Attributes.ContainsKey("i9_utilizar_rg_como_cnpj"))
            {
                this.i9_utilizar_rg_como_cnpj = GetValueAttribute(account["i9_utilizar_rg_como_cnpj"]);
            }
            if (account.Attributes.ContainsKey("importsequencenumber"))
            {
                this.importsequencenumber = GetValueAttribute(account["importsequencenumber"]);
            }
            if (account.Attributes.ContainsKey("industrycode"))
            {
                this.industrycode = GetValueAttribute(account["industrycode"]);
            }
            if (account.Attributes.ContainsKey("lastusedincampaign"))
            {
                this.lastusedincampaign = GetValueAttribute(account["lastusedincampaign"]);
            }
            if (account.Attributes.ContainsKey("marketcap"))
            {
                this.marketcap = GetValueAttribute(account["marketcap"]);
            }
            if (account.Attributes.ContainsKey("marketcap_base"))
            {
                this.marketcap_base = GetValueAttribute(account["marketcap_base"]);
            }
            if (account.Attributes.ContainsKey("masterid"))
            {
                this.masterid = GetValueAttribute(account["masterid"]);
            }
            if (account.Attributes.ContainsKey("merged"))
            {
                this.merged = GetValueAttribute(account["merged"]);
            }
            if (account.Attributes.ContainsKey("modifiedby"))
            {
                this.modifiedby = GetValueAttribute(account["modifiedby"]);
            }
            if (account.Attributes.ContainsKey("modifiedon"))
            {
                this.modifiedon = GetValueAttribute(account["modifiedon"]);
            }
            if (account.Attributes.ContainsKey("modifiedonbehalfby"))
            {
                this.modifiedonbehalfby = GetValueAttribute(account["modifiedonbehalfby"]);
            }
            if (account.Attributes.ContainsKey("name"))
            {
                this.name = GetValueAttribute(account["name"]);
            }
            if (account.Attributes.ContainsKey("new_cli_pagador"))
            {
                this.new_cli_pagador = GetValueAttribute(account["new_cli_pagador"]);
            }
            if (account.Attributes.ContainsKey("new_contato"))
            {
                this.new_contato = GetValueAttribute(account["new_contato"]);
            }
            if (account.Attributes.ContainsKey("new_contatoid"))
            {
                this.new_contatoid = GetValueAttribute(account["new_contatoid"]);
            }
            if (account.Attributes.ContainsKey("new_pai_codigo"))
            {
                this.new_pai_codigo = GetValueAttribute(account["new_pai_codigo"]);
            }
            if (account.Attributes.ContainsKey("new_pk_codigo"))
            {
                this.new_pk_codigo = GetValueAttribute(account["new_pk_codigo"]);
            }
            if (account.Attributes.ContainsKey("new_pk_emp_codigo"))
            {
                this.new_pk_emp_codigo = GetValueAttribute(account["new_pk_emp_codigo"]);
            }
            if (account.Attributes.ContainsKey("new_representante_codigo"))
            {
                this.new_representante_codigo = GetValueAttribute(account["new_representante_codigo"]);
            }
            if (account.Attributes.ContainsKey("new_telefonecomercial"))
            {
                this.new_telefonecomercial = GetValueAttribute(account["new_telefonecomercial"]);
            }
            if (account.Attributes.ContainsKey("numberofemployees"))
            {
                this.numberofemployees = GetValueAttribute(account["numberofemployees"]);
            }
            if (account.Attributes.ContainsKey("opendeals"))
            {
                this.opendeals = GetValueAttribute(account["opendeals"]);
            }
            if (account.Attributes.ContainsKey("openrevenue"))
            {
                this.openrevenue = GetValueAttribute(account["openrevenue"]);
            }
            if (account.Attributes.ContainsKey("openrevenue_base"))
            {
                this.openrevenue_base = GetValueAttribute(account["openrevenue_base"]);
            }
            if (account.Attributes.ContainsKey("originatingleadid"))
            {
                this.originatingleadid = GetValueAttribute(account["originatingleadid"]);
            }
            if (account.Attributes.ContainsKey("overriddencreatedon"))
            {
                this.overriddencreatedon = GetValueAttribute(account["overriddencreatedon"]);
            }
            if (account.Attributes.ContainsKey("ownerid"))
            {
                this.ownerid = GetValueAttribute(account["ownerid"]);
            }
            if (account.Attributes.ContainsKey("ownershipcode"))
            {
                this.ownershipcode = GetValueAttribute(account["ownershipcode"]);
            }
            if (account.Attributes.ContainsKey("owningbusinessunit"))
            {
                this.owningbusinessunit = GetValueAttribute(account["owningbusinessunit"]);
            }
            if (account.Attributes.ContainsKey("owningteam"))
            {
                this.owningteam = GetValueAttribute(account["owningteam"]);
            }
            if (account.Attributes.ContainsKey("owninguser"))
            {
                this.owninguser = GetValueAttribute(account["owninguser"]);
            }
            if (account.Attributes.ContainsKey("parentaccountid"))
            {
                this.parentaccountid = GetValueAttribute(account["parentaccountid"]);
            }
            if (account.Attributes.ContainsKey("participatesinworkflow"))
            {
                this.participatesinworkflow = GetValueAttribute(account["participatesinworkflow"]);
            }
            if (account.Attributes.ContainsKey("paymenttermscode"))
            {
                this.paymenttermscode = GetValueAttribute(account["paymenttermscode"]);
            }
            if (account.Attributes.ContainsKey("preferredappointmentdaycode"))
            {
                this.preferredappointmentdaycode = GetValueAttribute(account["preferredappointmentdaycode"]);
            }
            if (account.Attributes.ContainsKey("preferredappointmenttimecode"))
            {
                this.preferredappointmenttimecode = GetValueAttribute(account["preferredappointmenttimecode"]);
            }
            if (account.Attributes.ContainsKey("preferredcontactmethodcode"))
            {
                this.preferredcontactmethodcode = GetValueAttribute(account["preferredcontactmethodcode"]);
            }
            if (account.Attributes.ContainsKey("preferredequipmentid"))
            {
                this.preferredequipmentid = GetValueAttribute(account["preferredequipmentid"]);
            }
            if (account.Attributes.ContainsKey("preferredserviceid"))
            {
                this.preferredserviceid = GetValueAttribute(account["preferredserviceid"]);
            }
            if (account.Attributes.ContainsKey("preferredsystemuserid"))
            {
                this.preferredsystemuserid = GetValueAttribute(account["preferredsystemuserid"]);
            }
            if (account.Attributes.ContainsKey("primarycontactid"))
            {
                this.primarycontactid = GetValueAttribute(account["primarycontactid"]);
            }
            if (account.Attributes.ContainsKey("processid"))
            {
                this.processid = GetValueAttribute(account["processid"]);
            }
            if (account.Attributes.ContainsKey("revenue"))
            {
                this.revenue = GetValueAttribute(account["revenue"]);
            }
            if (account.Attributes.ContainsKey("revenue_base"))
            {
                this.revenue_base = GetValueAttribute(account["revenue_base"]);
            }
            if (account.Attributes.ContainsKey("sharesoutstanding"))
            {
                this.sharesoutstanding = GetValueAttribute(account["sharesoutstanding"]);
            }
            if (account.Attributes.ContainsKey("shippingmethodcode"))
            {
                this.shippingmethodcode = GetValueAttribute(account["shippingmethodcode"]);
            }
            if (account.Attributes.ContainsKey("sic"))
            {
                this.sic = GetValueAttribute(account["sic"]);
            }
            if (account.Attributes.ContainsKey("stageid"))
            {
                this.stageid = GetValueAttribute(account["stageid"]);
            }
            if (account.Attributes.ContainsKey("statecode"))
            {
                this.statecode = GetValueAttribute(account["statecode"]);
            }
            if (account.Attributes.ContainsKey("statuscode"))
            {
                this.statuscode = GetValueAttribute(account["statuscode"]);
            }
            if (account.Attributes.ContainsKey("stockexchange"))
            {
                this.stockexchange = GetValueAttribute(account["stockexchange"]);
            }
            if (account.Attributes.ContainsKey("telephone1"))
            {
                this.telephone1 = GetValueAttribute(account["telephone1"]);
            }
            if (account.Attributes.ContainsKey("telephone2"))
            {
                this.telephone2 = GetValueAttribute(account["telephone2"]);
            }
            if (account.Attributes.ContainsKey("telephone3"))
            {
                this.telephone3 = GetValueAttribute(account["telephone3"]);
            }
            if (account.Attributes.ContainsKey("territorycode"))
            {
                this.territorycode = GetValueAttribute(account["territorycode"]);
            }
            if (account.Attributes.ContainsKey("territoryid"))
            {
                this.territoryid = GetValueAttribute(account["territoryid"]);
            }
            if (account.Attributes.ContainsKey("tickersymbol"))
            {
                this.tickersymbol = GetValueAttribute(account["tickersymbol"]);
            }
            if (account.Attributes.ContainsKey("timezoneruleversionnumber"))
            {
                this.timezoneruleversionnumber = GetValueAttribute(account["timezoneruleversionnumber"]);
            }
            if (account.Attributes.ContainsKey("transactioncurrencyid"))
            {
                this.transactioncurrencyid = GetValueAttribute(account["transactioncurrencyid"]);
            }
            if (account.Attributes.ContainsKey("traversedpath"))
            {
                this.traversedpath = GetValueAttribute(account["traversedpath"]);
            }
            if (account.Attributes.ContainsKey("utcconversiontimezonecode"))
            {
                this.utcconversiontimezonecode = GetValueAttribute(account["utcconversiontimezonecode"]);
            }
            if (account.Attributes.ContainsKey("versionnumber"))
            {
                this.versionnumber = GetValueAttribute(account["versionnumber"]);
            }
            if (account.Attributes.ContainsKey("websiteurl"))
            {
                this.websiteurl = GetValueAttribute(account["websiteurl"]);
            }
            if (account.Attributes.ContainsKey("yominame"))
            {
                this.yominame = GetValueAttribute(account["yominame"]);
            }
        }

        public string GetValueAttribute(object oAttribute)
        {
            var sReturn = string.Empty;
            if (oAttribute.GetType().Equals(typeof(Microsoft.Xrm.Sdk.Money)))
            {
                sReturn = (oAttribute as Microsoft.Xrm.Sdk.Money).Value.ToString();
            }
            else if (oAttribute.GetType().Equals(typeof(Microsoft.Xrm.Sdk.EntityReference)))
            {
                sReturn = (oAttribute as Microsoft.Xrm.Sdk.EntityReference).Name;
            }
            else if (oAttribute.GetType().Equals(typeof(Microsoft.Xrm.Sdk.OptionSetValue)))
            {
                sReturn = (oAttribute as Microsoft.Xrm.Sdk.OptionSetValue).Value.ToString();
            }
            else
            {
                sReturn = oAttribute.ToString();
            }
            return sReturn;
        }
    }
}
