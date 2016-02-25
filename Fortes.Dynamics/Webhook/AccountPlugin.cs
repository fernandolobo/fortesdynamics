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
                this.accountcategorycode = account["accountcategorycode"].ToString();
            }
            if (account.Attributes.ContainsKey("accountclassificationcode"))
            {
                this.accountclassificationcode = account["accountclassificationcode"].ToString();
            }
            if (account.Attributes.ContainsKey("accountid"))
            {
                this.accountid = account["accountid"].ToString();
            }
            if (account.Attributes.ContainsKey("accountnumber"))
            {
                this.accountnumber = account["accountnumber"].ToString();
            }
            if (account.Attributes.ContainsKey("accountratingcode"))
            {
                this.accountratingcode = account["accountratingcode"].ToString();
            }
            if (account.Attributes.ContainsKey("address1_addressid"))
            {
                this.address1_addressid = account["address1_addressid"].ToString();
            }
            if (account.Attributes.ContainsKey("address1_addresstypecode"))
            {
                this.address1_addresstypecode = account["address1_addresstypecode"].ToString();
            }
            if (account.Attributes.ContainsKey("address1_city"))
            {
                this.address1_city = account["address1_city"].ToString();
            }
            if (account.Attributes.ContainsKey("address1_composite"))
            {
                this.address1_composite = account["address1_composite"].ToString();
            }
            if (account.Attributes.ContainsKey("address1_country"))
            {
                this.address1_country = account["address1_country"].ToString();
            }
            if (account.Attributes.ContainsKey("address1_county"))
            {
                this.address1_county = account["address1_county"].ToString();
            }
            if (account.Attributes.ContainsKey("address1_fax"))
            {
                this.address1_fax = account["address1_fax"].ToString();
            }
            if (account.Attributes.ContainsKey("address1_freighttermscode"))
            {
                this.address1_freighttermscode = account["address1_freighttermscode"].ToString();
            }
            if (account.Attributes.ContainsKey("address1_latitude"))
            {
                this.address1_latitude = account["address1_latitude"].ToString();
            }
            if (account.Attributes.ContainsKey("address1_line1"))
            {
                this.address1_line1 = account["address1_line1"].ToString();
            }
            if (account.Attributes.ContainsKey("address1_line2"))
            {
                this.address1_line2 = account["address1_line2"].ToString();
            }
            if (account.Attributes.ContainsKey("address1_line3"))
            {
                this.address1_line3 = account["address1_line3"].ToString();
            }
            if (account.Attributes.ContainsKey("address1_longitude"))
            {
                this.address1_longitude = account["address1_longitude"].ToString();
            }
            if (account.Attributes.ContainsKey("address1_name"))
            {
                this.address1_name = account["address1_name"].ToString();
            }
            if (account.Attributes.ContainsKey("address1_postalcode"))
            {
                this.address1_postalcode = account["address1_postalcode"].ToString();
            }
            if (account.Attributes.ContainsKey("address1_postofficebox"))
            {
                this.address1_postofficebox = account["address1_postofficebox"].ToString();
            }
            if (account.Attributes.ContainsKey("address1_primarycontactname"))
            {
                this.address1_primarycontactname = account["address1_primarycontactname"].ToString();
            }
            if (account.Attributes.ContainsKey("address1_shippingmethodcode"))
            {
                this.address1_shippingmethodcode = account["address1_shippingmethodcode"].ToString();
            }
            if (account.Attributes.ContainsKey("address1_stateorprovince"))
            {
                this.address1_stateorprovince = account["address1_stateorprovince"].ToString();
            }
            if (account.Attributes.ContainsKey("address1_telephone1"))
            {
                this.address1_telephone1 = account["address1_telephone1"].ToString();
            }
            if (account.Attributes.ContainsKey("address1_telephone2"))
            {
                this.address1_telephone2 = account["address1_telephone2"].ToString();
            }
            if (account.Attributes.ContainsKey("address1_telephone3"))
            {
                this.address1_telephone3 = account["address1_telephone3"].ToString();
            }
            if (account.Attributes.ContainsKey("address1_upszone"))
            {
                this.address1_upszone = account["address1_upszone"].ToString();
            }
            if (account.Attributes.ContainsKey("address1_utcoffset"))
            {
                this.address1_utcoffset = account["address1_utcoffset"].ToString();
            }
            if (account.Attributes.ContainsKey("address2_addressid"))
            {
                this.address2_addressid = account["address2_addressid"].ToString();
            }
            if (account.Attributes.ContainsKey("address2_addresstypecode"))
            {
                this.address2_addresstypecode = account["address2_addresstypecode"].ToString();
            }
            if (account.Attributes.ContainsKey("address2_city"))
            {
                this.address2_city = account["address2_city"].ToString();
            }
            if (account.Attributes.ContainsKey("address2_composite"))
            {
                this.address2_composite = account["address2_composite"].ToString();
            }
            if (account.Attributes.ContainsKey("address2_country"))
            {
                this.address2_country = account["address2_country"].ToString();
            }
            if (account.Attributes.ContainsKey("address2_county"))
            {
                this.address2_county = account["address2_county"].ToString();
            }
            if (account.Attributes.ContainsKey("address2_fax"))
            {
                this.address2_fax = account["address2_fax"].ToString();
            }
            if (account.Attributes.ContainsKey("address2_freighttermscode"))
            {
                this.address2_freighttermscode = account["address2_freighttermscode"].ToString();
            }
            if (account.Attributes.ContainsKey("address2_latitude"))
            {
                this.address2_latitude = account["address2_latitude"].ToString();
            }
            if (account.Attributes.ContainsKey("address2_line1"))
            {
                this.address2_line1 = account["address2_line1"].ToString();
            }
            if (account.Attributes.ContainsKey("address2_line2"))
            {
                this.address2_line2 = account["address2_line2"].ToString();
            }
            if (account.Attributes.ContainsKey("address2_line3"))
            {
                this.address2_line3 = account["address2_line3"].ToString();
            }
            if (account.Attributes.ContainsKey("address2_longitude"))
            {
                this.address2_longitude = account["address2_longitude"].ToString();
            }
            if (account.Attributes.ContainsKey("address2_name"))
            {
                this.address2_name = account["address2_name"].ToString();
            }
            if (account.Attributes.ContainsKey("address2_postalcode"))
            {
                this.address2_postalcode = account["address2_postalcode"].ToString();
            }
            if (account.Attributes.ContainsKey("address2_postofficebox"))
            {
                this.address2_postofficebox = account["address2_postofficebox"].ToString();
            }
            if (account.Attributes.ContainsKey("address2_primarycontactname"))
            {
                this.address2_primarycontactname = account["address2_primarycontactname"].ToString();
            }
            if (account.Attributes.ContainsKey("address2_shippingmethodcode"))
            {
                this.address2_shippingmethodcode = account["address2_shippingmethodcode"].ToString();
            }
            if (account.Attributes.ContainsKey("address2_stateorprovince"))
            {
                this.address2_stateorprovince = account["address2_stateorprovince"].ToString();
            }
            if (account.Attributes.ContainsKey("address2_telephone1"))
            {
                this.address2_telephone1 = account["address2_telephone1"].ToString();
            }
            if (account.Attributes.ContainsKey("address2_telephone2"))
            {
                this.address2_telephone2 = account["address2_telephone2"].ToString();
            }
            if (account.Attributes.ContainsKey("address2_telephone3"))
            {
                this.address2_telephone3 = account["address2_telephone3"].ToString();
            }
            if (account.Attributes.ContainsKey("address2_upszone"))
            {
                this.address2_upszone = account["address2_upszone"].ToString();
            }
            if (account.Attributes.ContainsKey("address2_utcoffset"))
            {
                this.address2_utcoffset = account["address2_utcoffset"].ToString();
            }
            if (account.Attributes.ContainsKey("aging30"))
            {
                this.aging30 = account["aging30"].ToString();
            }
            if (account.Attributes.ContainsKey("aging30_base"))
            {
                this.aging30_base = account["aging30_base"].ToString();
            }
            if (account.Attributes.ContainsKey("aging60"))
            {
                this.aging60 = account["aging60"].ToString();
            }
            if (account.Attributes.ContainsKey("aging60_base"))
            {
                this.aging60_base = account["aging60_base"].ToString();
            }
            if (account.Attributes.ContainsKey("aging90"))
            {
                this.aging90 = account["aging90"].ToString();
            }
            if (account.Attributes.ContainsKey("aging90_base"))
            {
                this.aging90_base = account["aging90_base"].ToString();
            }
            if (account.Attributes.ContainsKey("businesstypecode"))
            {
                this.businesstypecode = account["businesstypecode"].ToString();
            }
            if (account.Attributes.ContainsKey("createdby"))
            {
                this.createdby = account["createdby"].ToString();
            }
            if (account.Attributes.ContainsKey("createdon"))
            {
                this.createdon = account["createdon"].ToString();
            }
            if (account.Attributes.ContainsKey("createdonbehalfby"))
            {
                this.createdonbehalfby = account["createdonbehalfby"].ToString();
            }
            if (account.Attributes.ContainsKey("creditlimit"))
            {
                this.creditlimit = account["creditlimit"].ToString();
            }
            if (account.Attributes.ContainsKey("creditlimit_base"))
            {
                this.creditlimit_base = account["creditlimit_base"].ToString();
            }
            if (account.Attributes.ContainsKey("creditonhold"))
            {
                this.creditonhold = account["creditonhold"].ToString();
            }
            if (account.Attributes.ContainsKey("customersizecode"))
            {
                this.customersizecode = account["customersizecode"].ToString();
            }
            if (account.Attributes.ContainsKey("customertypecode"))
            {
                this.customertypecode = account["customertypecode"].ToString();
            }
            if (account.Attributes.ContainsKey("defaultpricelevelid"))
            {
                this.defaultpricelevelid = account["defaultpricelevelid"].ToString();
            }
            if (account.Attributes.ContainsKey("description"))
            {
                this.description = account["description"].ToString();
            }
            if (account.Attributes.ContainsKey("donotbulkemail"))
            {
                this.donotbulkemail = account["donotbulkemail"].ToString();
            }
            if (account.Attributes.ContainsKey("donotbulkpostalmail"))
            {
                this.donotbulkpostalmail = account["donotbulkpostalmail"].ToString();
            }
            if (account.Attributes.ContainsKey("donotemail"))
            {
                this.donotemail = account["donotemail"].ToString();
            }
            if (account.Attributes.ContainsKey("donotfax"))
            {
                this.donotfax = account["donotfax"].ToString();
            }
            if (account.Attributes.ContainsKey("donotphone"))
            {
                this.donotphone = account["donotphone"].ToString();
            }
            if (account.Attributes.ContainsKey("donotpostalmail"))
            {
                this.donotpostalmail = account["donotpostalmail"].ToString();
            }
            if (account.Attributes.ContainsKey("donotsendmm"))
            {
                this.donotsendmm = account["donotsendmm"].ToString();
            }
            if (account.Attributes.ContainsKey("emailaddress1"))
            {
                this.emailaddress1 = account["emailaddress1"].ToString();
            }
            if (account.Attributes.ContainsKey("emailaddress2"))
            {
                this.emailaddress2 = account["emailaddress2"].ToString();
            }
            if (account.Attributes.ContainsKey("emailaddress3"))
            {
                this.emailaddress3 = account["emailaddress3"].ToString();
            }
            if (account.Attributes.ContainsKey("entityimage"))
            {
                this.entityimage = account["entityimage"].ToString();
            }
            if (account.Attributes.ContainsKey("exchangerate"))
            {
                this.exchangerate = account["exchangerate"].ToString();
            }
            if (account.Attributes.ContainsKey("fax"))
            {
                this.fax = account["fax"].ToString();
            }
            if (account.Attributes.ContainsKey("ftpsiteurl"))
            {
                this.ftpsiteurl = account["ftpsiteurl"].ToString();
            }
            if (account.Attributes.ContainsKey("i9_aliquota"))
            {
                this.i9_aliquota = account["i9_aliquota"].ToString();
            }
            if (account.Attributes.ContainsKey("i9_bloquear_atendimento_cliente"))
            {
                this.i9_bloquear_atendimento_cliente = account["i9_bloquear_atendimento_cliente"].ToString();
            }
            if (account.Attributes.ContainsKey("i9_bloquear_conta"))
            {
                this.i9_bloquear_conta = account["i9_bloquear_conta"].ToString();
            }
            if (account.Attributes.ContainsKey("i9_bloqueia_licenca_uso_cliente"))
            {
                this.i9_bloqueia_licenca_uso_cliente = account["i9_bloqueia_licenca_uso_cliente"].ToString();
            }
            if (account.Attributes.ContainsKey("i9_celular_aux"))
            {
                this.i9_celular_aux = account["i9_celular_aux"].ToString();
            }
            if (account.Attributes.ContainsKey("i9_cidade"))
            {
                this.i9_cidade = account["i9_cidade"].ToString();
            }
            if (account.Attributes.ContainsKey("i9_cliente_pagador"))
            {
                this.i9_cliente_pagador = account["i9_cliente_pagador"].ToString();
            }
            if (account.Attributes.ContainsKey("i9_cliente_pagador_centraliza_hrs"))
            {
                this.i9_cliente_pagador_centraliza_hrs = account["i9_cliente_pagador_centraliza_hrs"].ToString();
            }
            if (account.Attributes.ContainsKey("i9_cobranca_impressa"))
            {
                this.i9_cobranca_impressa = account["i9_cobranca_impressa"].ToString();
            }
            if (account.Attributes.ContainsKey("i9_cofins"))
            {
                this.i9_cofins = account["i9_cofins"].ToString();
            }
            if (account.Attributes.ContainsKey("i9_conta_contabil"))
            {
                this.i9_conta_contabil = account["i9_conta_contabil"].ToString();
            }
            if (account.Attributes.ContainsKey("i9_cpf_cnpj"))
            {
                this.i9_cpf_cnpj = account["i9_cpf_cnpj"].ToString();
            }
            if (account.Attributes.ContainsKey("i9_cpf_cnpj_aux"))
            {
                this.i9_cpf_cnpj_aux = account["i9_cpf_cnpj_aux"].ToString();
            }
            if (account.Attributes.ContainsKey("i9_csll"))
            {
                this.i9_csll = account["i9_csll"].ToString();
            }
            if (account.Attributes.ContainsKey("i9_ddd_celular"))
            {
                this.i9_ddd_celular = account["i9_ddd_celular"].ToString();
            }
            if (account.Attributes.ContainsKey("i9_ddd_fax"))
            {
                this.i9_ddd_fax = account["i9_ddd_fax"].ToString();
            }
            if (account.Attributes.ContainsKey("i9_dddfone2"))
            {
                this.i9_dddfone2 = account["i9_dddfone2"].ToString();
            }
            if (account.Attributes.ContainsKey("i9_documento_estrangeiro"))
            {
                this.i9_documento_estrangeiro = account["i9_documento_estrangeiro"].ToString();
            }
            if (account.Attributes.ContainsKey("i9_estado"))
            {
                this.i9_estado = account["i9_estado"].ToString();
            }
            if (account.Attributes.ContainsKey("i9_etiqueta"))
            {
                this.i9_etiqueta = account["i9_etiqueta"].ToString();
            }
            if (account.Attributes.ContainsKey("i9_exterior"))
            {
                this.i9_exterior = account["i9_exterior"].ToString();
            }
            if (account.Attributes.ContainsKey("i9_fax_aux"))
            {
                this.i9_fax_aux = account["i9_fax_aux"].ToString();
            }
            if (account.Attributes.ContainsKey("i9_gerar_nf_automatica"))
            {
                this.i9_gerar_nf_automatica = account["i9_gerar_nf_automatica"].ToString();
            }
            if (account.Attributes.ContainsKey("i9_grupo"))
            {
                this.i9_grupo = account["i9_grupo"].ToString();
            }
            if (account.Attributes.ContainsKey("i9_indicador_inscricao_estadual_destinatario"))
            {
                this.i9_indicador_inscricao_estadual_destinatario = account["i9_indicador_inscricao_estadual_destinatario"].ToString();
            }
            if (account.Attributes.ContainsKey("i9_inscricao_estadual"))
            {
                this.i9_inscricao_estadual = account["i9_inscricao_estadual"].ToString();
            }
            if (account.Attributes.ContainsKey("i9_inscricao_municipal"))
            {
                this.i9_inscricao_municipal = account["i9_inscricao_municipal"].ToString();
            }
            if (account.Attributes.ContainsKey("i9_irrf"))
            {
                this.i9_irrf = account["i9_irrf"].ToString();
            }
            if (account.Attributes.ContainsKey("i9_isento_inscricao"))
            {
                this.i9_isento_inscricao = account["i9_isento_inscricao"].ToString();
            }
            if (account.Attributes.ContainsKey("i9_nao_cobra_atendimento_telefonico"))
            {
                this.i9_nao_cobra_atendimento_telefonico = account["i9_nao_cobra_atendimento_telefonico"].ToString();
            }
            if (account.Attributes.ContainsKey("i9_nome_fantasia"))
            {
                this.i9_nome_fantasia = account["i9_nome_fantasia"].ToString();
            }
            if (account.Attributes.ContainsKey("i9_observacao"))
            {
                this.i9_observacao = account["i9_observacao"].ToString();
            }
            if (account.Attributes.ContainsKey("i9_observacao_atendimento"))
            {
                this.i9_observacao_atendimento = account["i9_observacao_atendimento"].ToString();
            }
            if (account.Attributes.ContainsKey("i9_pais"))
            {
                this.i9_pais = account["i9_pais"].ToString();
            }
            if (account.Attributes.ContainsKey("i9_pis"))
            {
                this.i9_pis = account["i9_pis"].ToString();
            }
            if (account.Attributes.ContainsKey("i9_receita"))
            {
                this.i9_receita = account["i9_receita"].ToString();
            }
            if (account.Attributes.ContainsKey("i9_retem_inss"))
            {
                this.i9_retem_inss = account["i9_retem_inss"].ToString();
            }
            if (account.Attributes.ContainsKey("i9_retem_iss"))
            {
                this.i9_retem_iss = account["i9_retem_iss"].ToString();
            }
            if (account.Attributes.ContainsKey("i9_rg"))
            {
                this.i9_rg = account["i9_rg"].ToString();
            }
            if (account.Attributes.ContainsKey("i9_telephone1_aux"))
            {
                this.i9_telephone1_aux = account["i9_telephone1_aux"].ToString();
            }
            if (account.Attributes.ContainsKey("i9_transportadora"))
            {
                this.i9_transportadora = account["i9_transportadora"].ToString();
            }
            if (account.Attributes.ContainsKey("i9_utilizar_rg_como_cnpj"))
            {
                this.i9_utilizar_rg_como_cnpj = account["i9_utilizar_rg_como_cnpj"].ToString();
            }
            if (account.Attributes.ContainsKey("importsequencenumber"))
            {
                this.importsequencenumber = account["importsequencenumber"].ToString();
            }
            if (account.Attributes.ContainsKey("industrycode"))
            {
                this.industrycode = account["industrycode"].ToString();
            }
            if (account.Attributes.ContainsKey("lastusedincampaign"))
            {
                this.lastusedincampaign = account["lastusedincampaign"].ToString();
            }
            if (account.Attributes.ContainsKey("marketcap"))
            {
                this.marketcap = account["marketcap"].ToString();
            }
            if (account.Attributes.ContainsKey("marketcap_base"))
            {
                this.marketcap_base = account["marketcap_base"].ToString();
            }
            if (account.Attributes.ContainsKey("masterid"))
            {
                this.masterid = account["masterid"].ToString();
            }
            if (account.Attributes.ContainsKey("merged"))
            {
                this.merged = account["merged"].ToString();
            }
            if (account.Attributes.ContainsKey("modifiedby"))
            {
                this.modifiedby = account["modifiedby"].ToString();
            }
            if (account.Attributes.ContainsKey("modifiedon"))
            {
                this.modifiedon = account["modifiedon"].ToString();
            }
            if (account.Attributes.ContainsKey("modifiedonbehalfby"))
            {
                this.modifiedonbehalfby = account["modifiedonbehalfby"].ToString();
            }
            if (account.Attributes.ContainsKey("name"))
            {
                this.name = account["name"].ToString();
            }
            if (account.Attributes.ContainsKey("new_cli_pagador"))
            {
                this.new_cli_pagador = account["new_cli_pagador"].ToString();
            }
            if (account.Attributes.ContainsKey("new_contato"))
            {
                this.new_contato = account["new_contato"].ToString();
            }
            if (account.Attributes.ContainsKey("new_contatoid"))
            {
                this.new_contatoid = account["new_contatoid"].ToString();
            }
            if (account.Attributes.ContainsKey("new_pai_codigo"))
            {
                this.new_pai_codigo = account["new_pai_codigo"].ToString();
            }
            if (account.Attributes.ContainsKey("new_pk_codigo"))
            {
                this.new_pk_codigo = account["new_pk_codigo"].ToString();
            }
            if (account.Attributes.ContainsKey("new_pk_emp_codigo"))
            {
                this.new_pk_emp_codigo = account["new_pk_emp_codigo"].ToString();
            }
            if (account.Attributes.ContainsKey("new_representante_codigo"))
            {
                this.new_representante_codigo = account["new_representante_codigo"].ToString();
            }
            if (account.Attributes.ContainsKey("new_telefonecomercial"))
            {
                this.new_telefonecomercial = account["new_telefonecomercial"].ToString();
            }
            if (account.Attributes.ContainsKey("numberofemployees"))
            {
                this.numberofemployees = account["numberofemployees"].ToString();
            }
            if (account.Attributes.ContainsKey("opendeals"))
            {
                this.opendeals = account["opendeals"].ToString();
            }
            if (account.Attributes.ContainsKey("openrevenue"))
            {
                this.openrevenue = account["openrevenue"].ToString();
            }
            if (account.Attributes.ContainsKey("openrevenue_base"))
            {
                this.openrevenue_base = account["openrevenue_base"].ToString();
            }
            if (account.Attributes.ContainsKey("originatingleadid"))
            {
                this.originatingleadid = account["originatingleadid"].ToString();
            }
            if (account.Attributes.ContainsKey("overriddencreatedon"))
            {
                this.overriddencreatedon = account["overriddencreatedon"].ToString();
            }
            if (account.Attributes.ContainsKey("ownerid"))
            {
                this.ownerid = account["ownerid"].ToString();
            }
            if (account.Attributes.ContainsKey("ownershipcode"))
            {
                this.ownershipcode = account["ownershipcode"].ToString();
            }
            if (account.Attributes.ContainsKey("owningbusinessunit"))
            {
                this.owningbusinessunit = account["owningbusinessunit"].ToString();
            }
            if (account.Attributes.ContainsKey("owningteam"))
            {
                this.owningteam = account["owningteam"].ToString();
            }
            if (account.Attributes.ContainsKey("owninguser"))
            {
                this.owninguser = account["owninguser"].ToString();
            }
            if (account.Attributes.ContainsKey("parentaccountid"))
            {
                this.parentaccountid = account["parentaccountid"].ToString();
            }
            if (account.Attributes.ContainsKey("participatesinworkflow"))
            {
                this.participatesinworkflow = account["participatesinworkflow"].ToString();
            }
            if (account.Attributes.ContainsKey("paymenttermscode"))
            {
                this.paymenttermscode = account["paymenttermscode"].ToString();
            }
            if (account.Attributes.ContainsKey("preferredappointmentdaycode"))
            {
                this.preferredappointmentdaycode = account["preferredappointmentdaycode"].ToString();
            }
            if (account.Attributes.ContainsKey("preferredappointmenttimecode"))
            {
                this.preferredappointmenttimecode = account["preferredappointmenttimecode"].ToString();
            }
            if (account.Attributes.ContainsKey("preferredcontactmethodcode"))
            {
                this.preferredcontactmethodcode = account["preferredcontactmethodcode"].ToString();
            }
            if (account.Attributes.ContainsKey("preferredequipmentid"))
            {
                this.preferredequipmentid = account["preferredequipmentid"].ToString();
            }
            if (account.Attributes.ContainsKey("preferredserviceid"))
            {
                this.preferredserviceid = account["preferredserviceid"].ToString();
            }
            if (account.Attributes.ContainsKey("preferredsystemuserid"))
            {
                this.preferredsystemuserid = account["preferredsystemuserid"].ToString();
            }
            if (account.Attributes.ContainsKey("primarycontactid"))
            {
                this.primarycontactid = account["primarycontactid"].ToString();
            }
            if (account.Attributes.ContainsKey("processid"))
            {
                this.processid = account["processid"].ToString();
            }
            if (account.Attributes.ContainsKey("revenue"))
            {
                this.revenue = account["revenue"].ToString();
            }
            if (account.Attributes.ContainsKey("revenue_base"))
            {
                this.revenue_base = account["revenue_base"].ToString();
            }
            if (account.Attributes.ContainsKey("sharesoutstanding"))
            {
                this.sharesoutstanding = account["sharesoutstanding"].ToString();
            }
            if (account.Attributes.ContainsKey("shippingmethodcode"))
            {
                this.shippingmethodcode = account["shippingmethodcode"].ToString();
            }
            if (account.Attributes.ContainsKey("sic"))
            {
                this.sic = account["sic"].ToString();
            }
            if (account.Attributes.ContainsKey("stageid"))
            {
                this.stageid = account["stageid"].ToString();
            }
            if (account.Attributes.ContainsKey("statecode"))
            {
                this.statecode = account["statecode"].ToString();
            }
            if (account.Attributes.ContainsKey("statuscode"))
            {
                this.statuscode = account["statuscode"].ToString();
            }
            if (account.Attributes.ContainsKey("stockexchange"))
            {
                this.stockexchange = account["stockexchange"].ToString();
            }
            if (account.Attributes.ContainsKey("telephone1"))
            {
                this.telephone1 = account["telephone1"].ToString();
            }
            if (account.Attributes.ContainsKey("telephone2"))
            {
                this.telephone2 = account["telephone2"].ToString();
            }
            if (account.Attributes.ContainsKey("telephone3"))
            {
                this.telephone3 = account["telephone3"].ToString();
            }
            if (account.Attributes.ContainsKey("territorycode"))
            {
                this.territorycode = account["territorycode"].ToString();
            }
            if (account.Attributes.ContainsKey("territoryid"))
            {
                this.territoryid = account["territoryid"].ToString();
            }
            if (account.Attributes.ContainsKey("tickersymbol"))
            {
                this.tickersymbol = account["tickersymbol"].ToString();
            }
            if (account.Attributes.ContainsKey("timezoneruleversionnumber"))
            {
                this.timezoneruleversionnumber = account["timezoneruleversionnumber"].ToString();
            }
            if (account.Attributes.ContainsKey("transactioncurrencyid"))
            {
                this.transactioncurrencyid = account["transactioncurrencyid"].ToString();
            }
            if (account.Attributes.ContainsKey("traversedpath"))
            {
                this.traversedpath = account["traversedpath"].ToString();
            }
            if (account.Attributes.ContainsKey("utcconversiontimezonecode"))
            {
                this.utcconversiontimezonecode = account["utcconversiontimezonecode"].ToString();
            }
            if (account.Attributes.ContainsKey("versionnumber"))
            {
                this.versionnumber = account["versionnumber"].ToString();
            }
            if (account.Attributes.ContainsKey("websiteurl"))
            {
                this.websiteurl = account["websiteurl"].ToString();
            }
            if (account.Attributes.ContainsKey("yominame"))
            {
                this.yominame = account["yominame"].ToString();
            }
        }
    }
}
