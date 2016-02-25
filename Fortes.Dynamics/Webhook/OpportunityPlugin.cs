using System;
using System.Runtime.Serialization;
using Microsoft.Xrm.Sdk;
using Microsoft.Xrm.Sdk.Metadata;
using Microsoft.Xrm.Sdk.Messages;
using System.Collections.Generic;

namespace Webhook
{
    [DataContract]
    public class OpportunityLocal
    {
        [DataMember]
        public string test { get; set; }
        [DataMember]
        public string actualclosedate { get; set; }
        [DataMember]
        public string actualvalue { get; set; }
        [DataMember]
        public string actualvalue_base { get; set; }
        [DataMember]
        public string budgetamount { get; set; }
        [DataMember]
        public string budgetamount_base { get; set; }
        [DataMember]
        public string budgetstatus { get; set; }
        [DataMember]
        public string campaignid { get; set; }
        [DataMember]
        public string captureproposalfeedback { get; set; }
        [DataMember]
        public string closeprobability { get; set; }
        [DataMember]
        public string completefinalproposal { get; set; }
        [DataMember]
        public string completeinternalreview { get; set; }
        [DataMember]
        public string confirminterest { get; set; }
        [DataMember]
        public string createdby { get; set; }
        [DataMember]
        public string createdon { get; set; }
        [DataMember]
        public string createdonbehalfby { get; set; }
        [DataMember]
        public string currentsituation { get; set; }
        [DataMember]
        public string customerid { get; set; }
        [DataMember]
        public string customerneed { get; set; }
        [DataMember]
        public string customerpainpoints { get; set; }
        [DataMember]
        public string decisionmaker { get; set; }
        [DataMember]
        public string description { get; set; }
        [DataMember]
        public string developproposal { get; set; }
        [DataMember]
        public string discountamount { get; set; }
        [DataMember]
        public string discountamount_base { get; set; }
        [DataMember]
        public string discountpercentage { get; set; }
        [DataMember]
        public string estimatedclosedate { get; set; }
        [DataMember]
        public string estimatedvalue { get; set; }
        [DataMember]
        public string estimatedvalue_base { get; set; }
        [DataMember]
        public string evaluatefit { get; set; }
        [DataMember]
        public string exchangerate { get; set; }
        [DataMember]
        public string filedebrief { get; set; }
        [DataMember]
        public string finaldecisiondate { get; set; }
        [DataMember]
        public string freightamount { get; set; }
        [DataMember]
        public string freightamount_base { get; set; }
        [DataMember]
        public string i9_antecipo_minuta_contrato { get; set; }
        [DataMember]
        public string i9_case_sucesso { get; set; }
        [DataMember]
        public string i9_descricao_pgto_adesao { get; set; }
        [DataMember]
        public string i9_descricao_pgto_ass_usuario { get; set; }
        [DataMember]
        public string i9_descricao_pgto_atualizacao { get; set; }
        [DataMember]
        public string i9_descricao_pgto_customizacao { get; set; }
        [DataMember]
        public string i9_descricao_pgto_implantacao { get; set; }
        [DataMember]
        public string i9_descricao_pgto_manutencao { get; set; }
        [DataMember]
        public string i9_descricao_pgto_venda { get; set; }
        [DataMember]
        public string i9_forma_pgto_adesao { get; set; }
        [DataMember]
        public string i9_forma_pgto_ass_por_usuario { get; set; }
        [DataMember]
        public string i9_forma_pgto_atualizacao { get; set; }
        [DataMember]
        public string i9_forma_pgto_customizacao { get; set; }
        [DataMember]
        public string i9_forma_pgto_implantacao { get; set; }
        [DataMember]
        public string i9_forma_pgto_manutencao { get; set; }
        [DataMember]
        public string i9_forma_pgto_venda { get; set; }
        [DataMember]
        public string i9_gerente_desconto { get; set; }
        [DataMember]
        public string i9_ligacao_feita { get; set; }
        [DataMember]
        public string i9_origem { get; set; }
        [DataMember]
        public string i9_origem_do_cliente { get; set; }
        [DataMember]
        public string i9_patrocinadores_decisores { get; set; }
        [DataMember]
        public string i9_pesquiso_site_empresa { get; set; }
        [DataMember]
        public string i9_regiao { get; set; }
        [DataMember]
        public string i9_retirou_duvidas_aderencia_software { get; set; }
        [DataMember]
        public string i9_reuniao_decisores { get; set; }
        [DataMember]
        public string i9_segmento_compativel { get; set; }
        [DataMember]
        public string i9_segunda_reuniao { get; set; }
        [DataMember]
        public string i9_solicitacao_desconto { get; set; }
        [DataMember]
        public string i9_tabela_preco { get; set; }
        [DataMember]
        public string i9_tempo_medio_abertura { get; set; }
        [DataMember]
        public string i9_tempodefalha { get; set; }
        [DataMember]
        public string i9_testandosoma { get; set; }
        [DataMember]
        public string i9_unidade_negocio { get; set; }
        [DataMember]
        public string i9_vice_presidente_desconto { get; set; }
        [DataMember]
        public string i9_visita_agendada { get; set; }
        [DataMember]
        public string identifycompetitors { get; set; }
        [DataMember]
        public string identifycustomercontacts { get; set; }
        [DataMember]
        public string identifypursuitteam { get; set; }
        [DataMember]
        public string importsequencenumber { get; set; }
        [DataMember]
        public string initialcommunication { get; set; }
        [DataMember]
        public string isrevenuesystemcalculated { get; set; }
        [DataMember]
        public string modifiedby { get; set; }
        [DataMember]
        public string modifiedon { get; set; }
        [DataMember]
        public string modifiedonbehalfby { get; set; }
        [DataMember]
        public string name { get; set; }
        [DataMember]
        public string need { get; set; }
        [DataMember]
        public string new_cessodedireitodeusocdu { get; set; }
        [DataMember]
        public string new_cronograma_ajustado { get; set; }
        [DataMember]
        public string new_descrioparaimplantao { get; set; }
        [DataMember]
        public string new_parceiro { get; set; }
        [DataMember]
        public string opportunityid { get; set; }
        [DataMember]
        public string opportunityratingcode { get; set; }
        [DataMember]
        public string originatingleadid { get; set; }
        [DataMember]
        public string overriddencreatedon { get; set; }
        [DataMember]
        public string ownerid { get; set; }
        [DataMember]
        public string owningbusinessunit { get; set; }
        [DataMember]
        public string owningteam { get; set; }
        [DataMember]
        public string owninguser { get; set; }
        [DataMember]
        public string parentaccountid { get; set; }
        [DataMember]
        public string parentcontactid { get; set; }
        [DataMember]
        public string participatesinworkflow { get; set; }
        [DataMember]
        public string presentfinalproposal { get; set; }
        [DataMember]
        public string processid { get; set; }
        [DataMember]
        public string proposedsolution { get; set; }
        [DataMember]
        public string purchaseprocess { get; set; }
        [DataMember]
        public string purchasetimeframe { get; set; }
        [DataMember]
        public string pursuitdecision { get; set; }
        [DataMember]
        public string qualificationcomments { get; set; }
        [DataMember]
        public string quotecomments { get; set; }
        [DataMember]
        public string resolvefeedback { get; set; }
        [DataMember]
        public string salesstage { get; set; }
        [DataMember]
        public string salesstagecode { get; set; }
        [DataMember]
        public string schedulefollowup_prospect { get; set; }
        [DataMember]
        public string schedulefollowup_qualify { get; set; }
        [DataMember]
        public string scheduleproposalmeeting { get; set; }
        [DataMember]
        public string sendthankyounote { get; set; }
        [DataMember]
        public string stageid { get; set; }
        [DataMember]
        public string statecode { get; set; }
        [DataMember]
        public string statuscode { get; set; }
        [DataMember]
        public string stepid { get; set; }
        [DataMember]
        public string stepname { get; set; }
        [DataMember]
        public string timeline { get; set; }
        [DataMember]
        public string timezoneruleversionnumber { get; set; }
        [DataMember]
        public string totalamount { get; set; }
        [DataMember]
        public string totalamount_base { get; set; }
        [DataMember]
        public string totalamountlessfreight { get; set; }
        [DataMember]
        public string totalamountlessfreight_base { get; set; }
        [DataMember]
        public string totaldiscountamount { get; set; }
        [DataMember]
        public string totaldiscountamount_base { get; set; }
        [DataMember]
        public string totallineitemamount { get; set; }
        [DataMember]
        public string totallineitemamount_base { get; set; }
        [DataMember]
        public string totallineitemdiscountamount { get; set; }
        [DataMember]
        public string totallineitemdiscountamount_base { get; set; }
        [DataMember]
        public string totaltax { get; set; }
        [DataMember]
        public string totaltax_base { get; set; }
        [DataMember]
        public string transactioncurrencyid { get; set; }
        [DataMember]
        public string traversedpath { get; set; }
        [DataMember]
        public string utcconversiontimezonecode { get; set; }
        [DataMember]
        public string versionnumber { get; set; }
        [DataMember]
        public AccountLocal accountlocal { get; set; }
        [DataMember]
        public ICollection<ProductOpportunityLocal> productopportunitylocal { get; set; }

        public OpportunityLocal() { }
        
        public void SetOpportunityLocal(Entity opportunityWin)
        {
            test = "teste";
            if (opportunityWin.Attributes.ContainsKey("actualclosedate"))
            {
                this.actualclosedate = opportunityWin["actualclosedate"].ToString();
            }
            if (opportunityWin.Attributes.ContainsKey("actualvalue"))
            {
                this.actualvalue = ((Money)opportunityWin["actualvalue"]).Value.ToString();
            }
            if (opportunityWin.Attributes.ContainsKey("actualvalue_base"))
            {
                this.actualvalue_base = ((Money)opportunityWin["actualvalue_base"]).Value.ToString();
            }
            if (opportunityWin.Attributes.ContainsKey("budgetamount"))
            {
                this.budgetamount = ((Money)opportunityWin["budgetamount"]).Value.ToString();
            }
            if (opportunityWin.Attributes.ContainsKey("budgetamount_base"))
            {
                this.budgetamount_base = ((Money)opportunityWin["budgetamount_base"]).Value.ToString();
            }
            if (opportunityWin.Attributes.ContainsKey("budgetstatus"))
            {
                this.budgetstatus = opportunityWin["budgetstatus"].ToString();
            }
            if (opportunityWin.Attributes.ContainsKey("campaignid"))
            {
                this.campaignid = opportunityWin["campaignid"].ToString();
            }
            if (opportunityWin.Attributes.ContainsKey("captureproposalfeedback"))
            {
                this.captureproposalfeedback = opportunityWin["captureproposalfeedback"].ToString();
            }
            if (opportunityWin.Attributes.ContainsKey("closeprobability"))
            {
                this.closeprobability = opportunityWin["closeprobability"].ToString();
            }
            if (opportunityWin.Attributes.ContainsKey("completefinalproposal"))
            {
                this.completefinalproposal = opportunityWin["completefinalproposal"].ToString();
            }
            if (opportunityWin.Attributes.ContainsKey("completeinternalreview"))
            {
                this.completeinternalreview = opportunityWin["completeinternalreview"].ToString();
            }
            if (opportunityWin.Attributes.ContainsKey("confirminterest"))
            {
                this.confirminterest = opportunityWin["confirminterest"].ToString();
            }
            if (opportunityWin.Attributes.ContainsKey("createdby"))
            {
                this.createdby = ((EntityReference)opportunityWin["createdby"]).Name;
            }
            if (opportunityWin.Attributes.ContainsKey("createdon"))
            {
                this.createdon = opportunityWin["createdon"].ToString();
            }
            if (opportunityWin.Attributes.ContainsKey("createdonbehalfby"))
            {
                this.createdonbehalfby = opportunityWin["createdonbehalfby"].ToString();
            }
            if (opportunityWin.Attributes.ContainsKey("currentsituation"))
            {
                this.currentsituation = opportunityWin["currentsituation"].ToString();
            }
            if (opportunityWin.Attributes.ContainsKey("customerid"))
            {
                this.customerid = ((EntityReference)opportunityWin["customerid"]).Name;
            }
            if (opportunityWin.Attributes.ContainsKey("customerneed"))
            {
                this.customerneed = opportunityWin["customerneed"].ToString();
            }
            if (opportunityWin.Attributes.ContainsKey("customerpainpoints"))
            {
                this.customerpainpoints = opportunityWin["customerpainpoints"].ToString();
            }
            if (opportunityWin.Attributes.ContainsKey("decisionmaker"))
            {
                this.decisionmaker = opportunityWin["decisionmaker"].ToString();
            }
            if (opportunityWin.Attributes.ContainsKey("description"))
            {
                this.description = opportunityWin["description"].ToString();
            }
            if (opportunityWin.Attributes.ContainsKey("developproposal"))
            {
                this.developproposal = opportunityWin["developproposal"].ToString();
            }
            if (opportunityWin.Attributes.ContainsKey("discountamount"))
            {
                this.discountamount = opportunityWin["discountamount"].ToString();
            }
            if (opportunityWin.Attributes.ContainsKey("discountamount_base"))
            {
                this.discountamount_base = opportunityWin["discountamount_base"].ToString();
            }
            if (opportunityWin.Attributes.ContainsKey("discountpercentage"))
            {
                this.discountpercentage = opportunityWin["discountpercentage"].ToString();
            }
            if (opportunityWin.Attributes.ContainsKey("estimatedclosedate"))
            {
                this.estimatedclosedate = opportunityWin["estimatedclosedate"].ToString();
            }
            if (opportunityWin.Attributes.ContainsKey("estimatedvalue"))
            {
                this.estimatedvalue = ((Money)opportunityWin["estimatedvalue"]).Value.ToString();
            }
            if (opportunityWin.Attributes.ContainsKey("estimatedvalue_base"))
            {
                this.estimatedvalue_base = ((Money)opportunityWin["estimatedvalue_base"]).Value.ToString();
            }
            if (opportunityWin.Attributes.ContainsKey("evaluatefit"))
            {
                this.evaluatefit = opportunityWin["evaluatefit"].ToString();
            }
            if (opportunityWin.Attributes.ContainsKey("exchangerate"))
            {
                this.exchangerate = opportunityWin["exchangerate"].ToString();
            }
            if (opportunityWin.Attributes.ContainsKey("filedebrief"))
            {
                this.filedebrief = opportunityWin["filedebrief"].ToString();
            }
            if (opportunityWin.Attributes.ContainsKey("finaldecisiondate"))
            {
                this.finaldecisiondate = opportunityWin["finaldecisiondate"].ToString();
            }
            if (opportunityWin.Attributes.ContainsKey("freightamount"))
            {
                this.freightamount = opportunityWin["freightamount"].ToString();
            }
            if (opportunityWin.Attributes.ContainsKey("freightamount_base"))
            {
                this.freightamount_base = opportunityWin["freightamount_base"].ToString();
            }
            if (opportunityWin.Attributes.ContainsKey("i9_antecipo_minuta_contrato"))
            {
                this.i9_antecipo_minuta_contrato = opportunityWin["i9_antecipo_minuta_contrato"].ToString();
            }
            if (opportunityWin.Attributes.ContainsKey("i9_case_sucesso"))
            {
                this.i9_case_sucesso = opportunityWin["i9_case_sucesso"].ToString();
            }
            if (opportunityWin.Attributes.ContainsKey("i9_descricao_pgto_adesao"))
            {
                this.i9_descricao_pgto_adesao = opportunityWin["i9_descricao_pgto_adesao"].ToString();
            }
            if (opportunityWin.Attributes.ContainsKey("i9_descricao_pgto_ass_usuario"))
            {
                this.i9_descricao_pgto_ass_usuario = opportunityWin["i9_descricao_pgto_ass_usuario"].ToString();
            }
            if (opportunityWin.Attributes.ContainsKey("i9_descricao_pgto_atualizacao"))
            {
                this.i9_descricao_pgto_atualizacao = opportunityWin["i9_descricao_pgto_atualizacao"].ToString();
            }
            if (opportunityWin.Attributes.ContainsKey("i9_descricao_pgto_customizacao"))
            {
                this.i9_descricao_pgto_customizacao = opportunityWin["i9_descricao_pgto_customizacao"].ToString();
            }
            if (opportunityWin.Attributes.ContainsKey("i9_descricao_pgto_implantacao"))
            {
                this.i9_descricao_pgto_implantacao = opportunityWin["i9_descricao_pgto_implantacao"].ToString();
            }
            if (opportunityWin.Attributes.ContainsKey("i9_descricao_pgto_manutencao"))
            {
                this.i9_descricao_pgto_manutencao = opportunityWin["i9_descricao_pgto_manutencao"].ToString();
            }
            if (opportunityWin.Attributes.ContainsKey("i9_descricao_pgto_venda"))
            {
                this.i9_descricao_pgto_venda = opportunityWin["i9_descricao_pgto_venda"].ToString();
            }
            if (opportunityWin.Attributes.ContainsKey("i9_forma_pgto_adesao"))
            {
                this.i9_forma_pgto_adesao = ((OptionSetValue)opportunityWin["i9_forma_pgto_adesao"]).Value.ToString();
            }
            if (opportunityWin.Attributes.ContainsKey("i9_forma_pgto_ass_por_usuario"))
            {
                this.i9_forma_pgto_ass_por_usuario = ((OptionSetValue)opportunityWin["i9_forma_pgto_ass_por_usuario"]).Value.ToString();
            }
            if (opportunityWin.Attributes.ContainsKey("i9_forma_pgto_atualizacao"))
            {
                this.i9_forma_pgto_atualizacao = ((OptionSetValue)opportunityWin["i9_forma_pgto_atualizacao"]).Value.ToString();
            }
            if (opportunityWin.Attributes.ContainsKey("i9_forma_pgto_customizacao"))
            {
                this.i9_forma_pgto_customizacao = ((OptionSetValue)opportunityWin["i9_forma_pgto_customizacao"]).Value.ToString();
            }
            if (opportunityWin.Attributes.ContainsKey("i9_forma_pgto_implantacao"))
            {
                this.i9_forma_pgto_implantacao = ((OptionSetValue)opportunityWin["i9_forma_pgto_implantacao"]).Value.ToString();
            }
            if (opportunityWin.Attributes.ContainsKey("i9_forma_pgto_manutencao"))
            {
                this.i9_forma_pgto_manutencao = ((OptionSetValue)opportunityWin["i9_forma_pgto_manutencao"]).Value.ToString();
            }
            if (opportunityWin.Attributes.ContainsKey("i9_forma_pgto_venda"))
            {
                this.i9_forma_pgto_venda = ((OptionSetValue)opportunityWin["i9_forma_pgto_venda"]).Value.ToString();
            }
            if (opportunityWin.Attributes.ContainsKey("i9_gerente_desconto"))
            {
                this.i9_gerente_desconto = opportunityWin["i9_gerente_desconto"].ToString();
            }
            if (opportunityWin.Attributes.ContainsKey("i9_ligacao_feita"))
            {
                this.i9_ligacao_feita = opportunityWin["i9_ligacao_feita"].ToString();
            }
            if (opportunityWin.Attributes.ContainsKey("i9_origem"))
            {
                this.i9_origem = opportunityWin["i9_origem"].ToString();
            }
            if (opportunityWin.Attributes.ContainsKey("i9_origem_do_cliente"))
            {
                this.i9_origem_do_cliente = ((OptionSetValue)opportunityWin["i9_origem_do_cliente"]).Value.ToString();
            }
            if (opportunityWin.Attributes.ContainsKey("i9_patrocinadores_decisores"))
            {
                this.i9_patrocinadores_decisores = opportunityWin["i9_patrocinadores_decisores"].ToString();
            }
            if (opportunityWin.Attributes.ContainsKey("i9_pesquiso_site_empresa"))
            {
                this.i9_pesquiso_site_empresa = opportunityWin["i9_pesquiso_site_empresa"].ToString();
            }
            if (opportunityWin.Attributes.ContainsKey("i9_regiao"))
            {
                this.i9_regiao = ((EntityReference)opportunityWin["i9_regiao"]).Name;
            }
            if (opportunityWin.Attributes.ContainsKey("i9_retirou_duvidas_aderencia_software"))
            {
                this.i9_retirou_duvidas_aderencia_software = opportunityWin["i9_retirou_duvidas_aderencia_software"].ToString();
            }
            if (opportunityWin.Attributes.ContainsKey("i9_reuniao_decisores"))
            {
                this.i9_reuniao_decisores = opportunityWin["i9_reuniao_decisores"].ToString();
            }
            if (opportunityWin.Attributes.ContainsKey("i9_segmento_compativel"))
            {
                this.i9_segmento_compativel = opportunityWin["i9_segmento_compativel"].ToString();
            }
            if (opportunityWin.Attributes.ContainsKey("i9_segunda_reuniao"))
            {
                this.i9_segunda_reuniao = opportunityWin["i9_segunda_reuniao"].ToString();
            }
            if (opportunityWin.Attributes.ContainsKey("i9_solicitacao_desconto"))
            {
                this.i9_solicitacao_desconto = opportunityWin["i9_solicitacao_desconto"].ToString();
            }
            if (opportunityWin.Attributes.ContainsKey("i9_tabela_preco"))
            {
                this.i9_tabela_preco = ((EntityReference)opportunityWin["i9_tabela_preco"]).Name;
            }
            if (opportunityWin.Attributes.ContainsKey("i9_tempodefalha"))
            {
                this.i9_tempodefalha = opportunityWin["i9_tempodefalha"].ToString();
            }
            if (opportunityWin.Attributes.ContainsKey("i9_tempo_medio_abertura"))
            {
                this.i9_tempo_medio_abertura = opportunityWin["i9_tempo_medio_abertura"].ToString();
            }
            if (opportunityWin.Attributes.ContainsKey("i9_testandosoma"))
            {
                this.i9_testandosoma = opportunityWin["i9_testandosoma"].ToString();
            }
            if (opportunityWin.Attributes.ContainsKey("i9_unidade_negocio"))
            {
                this.i9_unidade_negocio = ((EntityReference)opportunityWin["i9_unidade_negocio"]).Name;
            }
            if (opportunityWin.Attributes.ContainsKey("i9_vice_presidente_desconto"))
            {
                this.i9_vice_presidente_desconto = opportunityWin["i9_vice_presidente_desconto"].ToString();
            }
            if (opportunityWin.Attributes.ContainsKey("i9_visita_agendada"))
            {
                this.i9_visita_agendada = opportunityWin["i9_visita_agendada"].ToString();
            }
            if (opportunityWin.Attributes.ContainsKey("identifycompetitors"))
            {
                this.identifycompetitors = opportunityWin["identifycompetitors"].ToString();
            }
            if (opportunityWin.Attributes.ContainsKey("identifycustomercontacts"))
            {
                this.identifycustomercontacts = opportunityWin["identifycustomercontacts"].ToString();
            }
            if (opportunityWin.Attributes.ContainsKey("identifypursuitteam"))
            {
                this.identifypursuitteam = opportunityWin["identifypursuitteam"].ToString();
            }
            if (opportunityWin.Attributes.ContainsKey("importsequencenumber"))
            {
                this.importsequencenumber = opportunityWin["importsequencenumber"].ToString();
            }
            if (opportunityWin.Attributes.ContainsKey("initialcommunication"))
            {
                this.initialcommunication = opportunityWin["initialcommunication"].ToString();
            }
            if (opportunityWin.Attributes.ContainsKey("isrevenuesystemcalculated"))
            {
                this.isrevenuesystemcalculated = opportunityWin["isrevenuesystemcalculated"].ToString();
            }
            if (opportunityWin.Attributes.ContainsKey("modifiedby"))
            {
                this.modifiedby = ((EntityReference)opportunityWin["modifiedby"]).Name;
            }
            if (opportunityWin.Attributes.ContainsKey("modifiedon"))
            {
                this.modifiedon = opportunityWin["modifiedon"].ToString();
            }
            if (opportunityWin.Attributes.ContainsKey("modifiedonbehalfby"))
            {
                this.modifiedonbehalfby = opportunityWin["modifiedonbehalfby"].ToString();
            }
            if (opportunityWin.Attributes.ContainsKey("name"))
            {
                this.name = opportunityWin["name"].ToString();
            }
            if (opportunityWin.Attributes.ContainsKey("need"))
            {
                this.need = opportunityWin["need"].ToString();
            }
            if (opportunityWin.Attributes.ContainsKey("new_cessodedireitodeusocdu"))
            {
                this.new_cessodedireitodeusocdu = ((OptionSetValue)opportunityWin["new_cessodedireitodeusocdu"]).Value.ToString();
            }
            if (opportunityWin.Attributes.ContainsKey("new_cronograma_ajustado"))
            {
                this.new_cronograma_ajustado = opportunityWin["new_cronograma_ajustado"].ToString();
            }
            if (opportunityWin.Attributes.ContainsKey("new_descrioparaimplantao"))
            {
                this.new_descrioparaimplantao = opportunityWin["new_descrioparaimplantao"].ToString();
            }
            if (opportunityWin.Attributes.ContainsKey("new_parceiro"))
            {
                this.new_parceiro = opportunityWin["new_parceiro"].ToString();
            }
            if (opportunityWin.Attributes.ContainsKey("opportunityid"))
            {
                this.opportunityid = opportunityWin["opportunityid"].ToString();
            }
            if (opportunityWin.Attributes.ContainsKey("opportunityratingcode"))
            {
                this.opportunityratingcode = ((OptionSetValue)opportunityWin["opportunityratingcode"]).Value.ToString();
            }
            if (opportunityWin.Attributes.ContainsKey("originatingleadid"))
            {
                this.originatingleadid = ((EntityReference)opportunityWin["originatingleadid"]).Name;
            }
            if (opportunityWin.Attributes.ContainsKey("overriddencreatedon"))
            {
                this.overriddencreatedon = opportunityWin["overriddencreatedon"].ToString();
            }
            if (opportunityWin.Attributes.ContainsKey("ownerid"))
            {
                this.ownerid = ((EntityReference)opportunityWin["ownerid"]).Name;
            }
            if (opportunityWin.Attributes.ContainsKey("owningbusinessunit"))
            {
                this.owningbusinessunit = ((EntityReference)opportunityWin["owningbusinessunit"]).Name;
            }
            if (opportunityWin.Attributes.ContainsKey("owningteam"))
            {
                this.owningteam = opportunityWin["owningteam"].ToString();
            }
            if (opportunityWin.Attributes.ContainsKey("owninguser"))
            {
                this.owninguser = ((EntityReference)opportunityWin["owninguser"]).Name;
            }
            if (opportunityWin.Attributes.ContainsKey("parentaccountid"))
            {
                this.parentaccountid = ((EntityReference)opportunityWin["parentaccountid"]).Name;
            }
            if (opportunityWin.Attributes.ContainsKey("parentcontactid"))
            {
                this.parentcontactid = ((EntityReference)opportunityWin["parentcontactid"]).Name;
            }
            if (opportunityWin.Attributes.ContainsKey("participatesinworkflow"))
            {
                this.participatesinworkflow = opportunityWin["participatesinworkflow"].ToString();
            }
            if (opportunityWin.Attributes.ContainsKey("presentfinalproposal"))
            {
                this.presentfinalproposal = opportunityWin["presentfinalproposal"].ToString();
            }
            if (opportunityWin.Attributes.ContainsKey("processid"))
            {
                this.processid = opportunityWin["processid"].ToString();
            }
            if (opportunityWin.Attributes.ContainsKey("proposedsolution"))
            {
                this.proposedsolution = opportunityWin["proposedsolution"].ToString();
            }
            if (opportunityWin.Attributes.ContainsKey("purchaseprocess"))
            {
                this.purchaseprocess = opportunityWin["purchaseprocess"].ToString();
            }
            if (opportunityWin.Attributes.ContainsKey("purchasetimeframe"))
            {
                this.purchasetimeframe = opportunityWin["purchasetimeframe"].ToString();
            }
            if (opportunityWin.Attributes.ContainsKey("pursuitdecision"))
            {
                this.pursuitdecision = opportunityWin["pursuitdecision"].ToString();
            }
            if (opportunityWin.Attributes.ContainsKey("qualificationcomments"))
            {
                this.qualificationcomments = opportunityWin["qualificationcomments"].ToString();
            }
            if (opportunityWin.Attributes.ContainsKey("quotecomments"))
            {
                this.quotecomments = opportunityWin["quotecomments"].ToString();
            }
            if (opportunityWin.Attributes.ContainsKey("resolvefeedback"))
            {
                this.resolvefeedback = opportunityWin["resolvefeedback"].ToString();
            }
            if (opportunityWin.Attributes.ContainsKey("salesstage"))
            {
                this.salesstage = ((OptionSetValue)opportunityWin["salesstage"]).Value.ToString();
            }
            if (opportunityWin.Attributes.ContainsKey("salesstagecode"))
            {
                this.salesstagecode = ((OptionSetValue)opportunityWin["salesstagecode"]).Value.ToString();
            }
            if (opportunityWin.Attributes.ContainsKey("schedulefollowup_prospect"))
            {
                this.schedulefollowup_prospect = opportunityWin["schedulefollowup_prospect"].ToString();
            }
            if (opportunityWin.Attributes.ContainsKey("schedulefollowup_qualify"))
            {
                this.schedulefollowup_qualify = opportunityWin["schedulefollowup_qualify"].ToString();
            }
            if (opportunityWin.Attributes.ContainsKey("scheduleproposalmeeting"))
            {
                this.scheduleproposalmeeting = opportunityWin["scheduleproposalmeeting"].ToString();
            }
            if (opportunityWin.Attributes.ContainsKey("sendthankyounote"))
            {
                this.sendthankyounote = opportunityWin["sendthankyounote"].ToString();
            }
            if (opportunityWin.Attributes.ContainsKey("stageid"))
            {
                this.stageid = opportunityWin["stageid"].ToString();
            }
            if (opportunityWin.Attributes.ContainsKey("statecode"))
            {
                this.statecode = ((OptionSetValue)opportunityWin["statecode"]).Value.ToString();
            }
            if (opportunityWin.Attributes.ContainsKey("statuscode"))
            {
                this.statuscode = ((OptionSetValue)opportunityWin["statuscode"]).Value.ToString();
            }
            if (opportunityWin.Attributes.ContainsKey("stepid"))
            {
                this.stepid = opportunityWin["stepid"].ToString();
            }
            if (opportunityWin.Attributes.ContainsKey("stepname"))
            {
                this.stepname = opportunityWin["stepname"].ToString();
            }
            if (opportunityWin.Attributes.ContainsKey("timeline"))
            {
                this.timeline = opportunityWin["timeline"].ToString();
            }
            if (opportunityWin.Attributes.ContainsKey("timezoneruleversionnumber"))
            {
                this.timezoneruleversionnumber = opportunityWin["timezoneruleversionnumber"].ToString();
            }
            if (opportunityWin.Attributes.ContainsKey("totalamount"))
            {
                this.totalamount = ((Money)opportunityWin["totalamount"]).Value.ToString();
            }
            if (opportunityWin.Attributes.ContainsKey("totalamountlessfreight"))
            {
                this.totalamountlessfreight = ((Money)opportunityWin["totalamountlessfreight"]).Value.ToString();
            }
            if (opportunityWin.Attributes.ContainsKey("totalamountlessfreight_base"))
            {
                this.totalamountlessfreight_base = ((Money)opportunityWin["totalamountlessfreight_base"]).Value.ToString();
            }
            if (opportunityWin.Attributes.ContainsKey("totalamount_base"))
            {
                this.totalamount_base = ((Money)opportunityWin["totalamount_base"]).Value.ToString();
            }
            if (opportunityWin.Attributes.ContainsKey("totaldiscountamount"))
            {
                this.totaldiscountamount = ((Money)opportunityWin["totaldiscountamount"]).Value.ToString();
            }
            if (opportunityWin.Attributes.ContainsKey("totaldiscountamount_base"))
            {
                this.totaldiscountamount_base = ((Money)opportunityWin["totaldiscountamount_base"]).Value.ToString();
            }
            if (opportunityWin.Attributes.ContainsKey("totallineitemamount"))
            {
                this.totallineitemamount = ((Money)opportunityWin["totallineitemamount"]).Value.ToString();
            }
            if (opportunityWin.Attributes.ContainsKey("totallineitemamount_base"))
            {
                this.totallineitemamount_base = ((Money)opportunityWin["totallineitemamount_base"]).Value.ToString();
            }
            if (opportunityWin.Attributes.ContainsKey("totallineitemdiscountamount"))
            {
                this.totallineitemdiscountamount = ((Money)opportunityWin["totallineitemdiscountamount"]).Value.ToString();
            }
            if (opportunityWin.Attributes.ContainsKey("totallineitemdiscountamount_base"))
            {
                this.totallineitemdiscountamount_base = ((Money)opportunityWin["totallineitemdiscountamount_base"]).Value.ToString();
            }
            if (opportunityWin.Attributes.ContainsKey("totaltax"))
            {
                this.totaltax = ((Money)opportunityWin["totaltax"]).Value.ToString();
            }
            if (opportunityWin.Attributes.ContainsKey("totaltax_base"))
            {
                this.totaltax_base = ((Money)opportunityWin["totaltax_base"]).Value.ToString();
            }
            if (opportunityWin.Attributes.ContainsKey("transactioncurrencyid"))
            {
                this.transactioncurrencyid = ((EntityReference)opportunityWin["transactioncurrencyid"]).Name;
            }
            if (opportunityWin.Attributes.ContainsKey("traversedpath"))
            {
                this.traversedpath = opportunityWin["traversedpath"].ToString();
            }
            if (opportunityWin.Attributes.ContainsKey("utcconversiontimezonecode"))
            {
                this.utcconversiontimezonecode = opportunityWin["utcconversiontimezonecode"].ToString();
            }
            if (opportunityWin.Attributes.ContainsKey("versionnumber"))
            {
                this.versionnumber = opportunityWin["versionnumber"].ToString();
            }
        }
    }
}
