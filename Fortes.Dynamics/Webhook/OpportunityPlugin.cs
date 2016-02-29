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
                this.actualclosedate = GetValueAttribute(opportunityWin["actualclosedate"]);
            }
            if (opportunityWin.Attributes.ContainsKey("actualvalue"))
            {
                this.actualvalue = GetValueAttribute(opportunityWin["actualvalue"]);
            }
            if (opportunityWin.Attributes.ContainsKey("actualvalue_base"))
            {
                this.actualvalue_base = GetValueAttribute(opportunityWin["actualvalue_base"]);
            }
            if (opportunityWin.Attributes.ContainsKey("budgetamount"))
            {
                this.budgetamount = GetValueAttribute(opportunityWin["budgetamount"]);
            }
            if (opportunityWin.Attributes.ContainsKey("budgetamount_base"))
            {
                this.budgetamount_base = GetValueAttribute(opportunityWin["budgetamount_base"]);
            }
            if (opportunityWin.Attributes.ContainsKey("budgetstatus"))
            {
                this.budgetstatus = GetValueAttribute(opportunityWin["budgetstatus"]);
            }
            if (opportunityWin.Attributes.ContainsKey("campaignid"))
            {
                this.campaignid = GetValueAttribute(opportunityWin["campaignid"]);
            }
            if (opportunityWin.Attributes.ContainsKey("captureproposalfeedback"))
            {
                this.captureproposalfeedback = GetValueAttribute(opportunityWin["captureproposalfeedback"]);
            }
            if (opportunityWin.Attributes.ContainsKey("closeprobability"))
            {
                this.closeprobability = GetValueAttribute(opportunityWin["closeprobability"]);
            }
            if (opportunityWin.Attributes.ContainsKey("completefinalproposal"))
            {
                this.completefinalproposal = GetValueAttribute(opportunityWin["completefinalproposal"]);
            }
            if (opportunityWin.Attributes.ContainsKey("completeinternalreview"))
            {
                this.completeinternalreview = GetValueAttribute(opportunityWin["completeinternalreview"]);
            }
            if (opportunityWin.Attributes.ContainsKey("confirminterest"))
            {
                this.confirminterest = GetValueAttribute(opportunityWin["confirminterest"]);
            }
            if (opportunityWin.Attributes.ContainsKey("createdby"))
            {
                this.createdby = GetValueAttribute(opportunityWin["createdby"]);
            }
            if (opportunityWin.Attributes.ContainsKey("createdon"))
            {
                this.createdon = GetValueAttribute(opportunityWin["createdon"]);
            }
            if (opportunityWin.Attributes.ContainsKey("createdonbehalfby"))
            {
                this.createdonbehalfby = GetValueAttribute(opportunityWin["createdonbehalfby"]);
            }
            if (opportunityWin.Attributes.ContainsKey("currentsituation"))
            {
                this.currentsituation = GetValueAttribute(opportunityWin["currentsituation"]);
            }
            if (opportunityWin.Attributes.ContainsKey("customerid"))
            {
                this.customerid = GetValueAttribute(opportunityWin["customerid"]);
            }
            if (opportunityWin.Attributes.ContainsKey("customerneed"))
            {
                this.customerneed = GetValueAttribute(opportunityWin["customerneed"]);
            }
            if (opportunityWin.Attributes.ContainsKey("customerpainpoints"))
            {
                this.customerpainpoints = GetValueAttribute(opportunityWin["customerpainpoints"]);
            }
            if (opportunityWin.Attributes.ContainsKey("decisionmaker"))
            {
                this.decisionmaker = GetValueAttribute(opportunityWin["decisionmaker"]);
            }
            if (opportunityWin.Attributes.ContainsKey("description"))
            {
                this.description = GetValueAttribute(opportunityWin["description"]);
            }
            if (opportunityWin.Attributes.ContainsKey("developproposal"))
            {
                this.developproposal = GetValueAttribute(opportunityWin["developproposal"]);
            }
            if (opportunityWin.Attributes.ContainsKey("discountamount"))
            {
                this.discountamount = GetValueAttribute(opportunityWin["discountamount"]);
            }
            if (opportunityWin.Attributes.ContainsKey("discountamount_base"))
            {
                this.discountamount_base = GetValueAttribute(opportunityWin["discountamount_base"]);
            }
            if (opportunityWin.Attributes.ContainsKey("discountpercentage"))
            {
                this.discountpercentage = GetValueAttribute(opportunityWin["discountpercentage"]);
            }
            if (opportunityWin.Attributes.ContainsKey("estimatedclosedate"))
            {
                this.estimatedclosedate = GetValueAttribute(opportunityWin["estimatedclosedate"]);
            }
            if (opportunityWin.Attributes.ContainsKey("estimatedvalue"))
            {
                this.estimatedvalue = GetValueAttribute(opportunityWin["estimatedvalue"]);
            }
            if (opportunityWin.Attributes.ContainsKey("estimatedvalue_base"))
            {
                this.estimatedvalue_base = GetValueAttribute(opportunityWin["estimatedvalue_base"]);
            }
            if (opportunityWin.Attributes.ContainsKey("evaluatefit"))
            {
                this.evaluatefit = GetValueAttribute(opportunityWin["evaluatefit"]);
            }
            if (opportunityWin.Attributes.ContainsKey("exchangerate"))
            {
                this.exchangerate = GetValueAttribute(opportunityWin["exchangerate"]);
            }
            if (opportunityWin.Attributes.ContainsKey("filedebrief"))
            {
                this.filedebrief = GetValueAttribute(opportunityWin["filedebrief"]);
            }
            if (opportunityWin.Attributes.ContainsKey("finaldecisiondate"))
            {
                this.finaldecisiondate = GetValueAttribute(opportunityWin["finaldecisiondate"]);
            }
            if (opportunityWin.Attributes.ContainsKey("freightamount"))
            {
                this.freightamount = GetValueAttribute(opportunityWin["freightamount"]);
            }
            if (opportunityWin.Attributes.ContainsKey("freightamount_base"))
            {
                this.freightamount_base = GetValueAttribute(opportunityWin["freightamount_base"]);
            }
            if (opportunityWin.Attributes.ContainsKey("i9_antecipo_minuta_contrato"))
            {
                this.i9_antecipo_minuta_contrato = GetValueAttribute(opportunityWin["i9_antecipo_minuta_contrato"]);
            }
            if (opportunityWin.Attributes.ContainsKey("i9_case_sucesso"))
            {
                this.i9_case_sucesso = GetValueAttribute(opportunityWin["i9_case_sucesso"]);
            }
            if (opportunityWin.Attributes.ContainsKey("i9_descricao_pgto_adesao"))
            {
                this.i9_descricao_pgto_adesao = GetValueAttribute(opportunityWin["i9_descricao_pgto_adesao"]);
            }
            if (opportunityWin.Attributes.ContainsKey("i9_descricao_pgto_ass_usuario"))
            {
                this.i9_descricao_pgto_ass_usuario = GetValueAttribute(opportunityWin["i9_descricao_pgto_ass_usuario"]);
            }
            if (opportunityWin.Attributes.ContainsKey("i9_descricao_pgto_atualizacao"))
            {
                this.i9_descricao_pgto_atualizacao = GetValueAttribute(opportunityWin["i9_descricao_pgto_atualizacao"]);
            }
            if (opportunityWin.Attributes.ContainsKey("i9_descricao_pgto_customizacao"))
            {
                this.i9_descricao_pgto_customizacao = GetValueAttribute(opportunityWin["i9_descricao_pgto_customizacao"]);
            }
            if (opportunityWin.Attributes.ContainsKey("i9_descricao_pgto_implantacao"))
            {
                this.i9_descricao_pgto_implantacao = GetValueAttribute(opportunityWin["i9_descricao_pgto_implantacao"]);
            }
            if (opportunityWin.Attributes.ContainsKey("i9_descricao_pgto_manutencao"))
            {
                this.i9_descricao_pgto_manutencao = GetValueAttribute(opportunityWin["i9_descricao_pgto_manutencao"]);
            }
            if (opportunityWin.Attributes.ContainsKey("i9_descricao_pgto_venda"))
            {
                this.i9_descricao_pgto_venda = GetValueAttribute(opportunityWin["i9_descricao_pgto_venda"]);
            }
            if (opportunityWin.Attributes.ContainsKey("i9_forma_pgto_adesao"))
            {
                this.i9_forma_pgto_adesao = GetValueAttribute(opportunityWin["i9_forma_pgto_adesao"]);
            }
            if (opportunityWin.Attributes.ContainsKey("i9_forma_pgto_ass_por_usuario"))
            {
                this.i9_forma_pgto_ass_por_usuario = GetValueAttribute(opportunityWin["i9_forma_pgto_ass_por_usuario"]);
            }
            if (opportunityWin.Attributes.ContainsKey("i9_forma_pgto_atualizacao"))
            {
                this.i9_forma_pgto_atualizacao = GetValueAttribute(opportunityWin["i9_forma_pgto_atualizacao"]);
            }
            if (opportunityWin.Attributes.ContainsKey("i9_forma_pgto_customizacao"))
            {
                this.i9_forma_pgto_customizacao = GetValueAttribute(opportunityWin["i9_forma_pgto_customizacao"]);
            }
            if (opportunityWin.Attributes.ContainsKey("i9_forma_pgto_implantacao"))
            {
                this.i9_forma_pgto_implantacao = GetValueAttribute(opportunityWin["i9_forma_pgto_implantacao"]);
            }
            if (opportunityWin.Attributes.ContainsKey("i9_forma_pgto_manutencao"))
            {
                this.i9_forma_pgto_manutencao = GetValueAttribute(opportunityWin["i9_forma_pgto_manutencao"]);
            }
            if (opportunityWin.Attributes.ContainsKey("i9_forma_pgto_venda"))
            {
                this.i9_forma_pgto_venda = GetValueAttribute(opportunityWin["i9_forma_pgto_venda"]);
            }
            if (opportunityWin.Attributes.ContainsKey("i9_gerente_desconto"))
            {
                this.i9_gerente_desconto = GetValueAttribute(opportunityWin["i9_gerente_desconto"]);
            }
            if (opportunityWin.Attributes.ContainsKey("i9_ligacao_feita"))
            {
                this.i9_ligacao_feita = GetValueAttribute(opportunityWin["i9_ligacao_feita"]);
            }
            if (opportunityWin.Attributes.ContainsKey("i9_origem"))
            {
                this.i9_origem = GetValueAttribute(opportunityWin["i9_origem"]);
            }
            if (opportunityWin.Attributes.ContainsKey("i9_origem_do_cliente"))
            {
                this.i9_origem_do_cliente = GetValueAttribute(opportunityWin["i9_origem_do_cliente"]);
            }
            if (opportunityWin.Attributes.ContainsKey("i9_patrocinadores_decisores"))
            {
                this.i9_patrocinadores_decisores = GetValueAttribute(opportunityWin["i9_patrocinadores_decisores"]);
            }
            if (opportunityWin.Attributes.ContainsKey("i9_pesquiso_site_empresa"))
            {
                this.i9_pesquiso_site_empresa = GetValueAttribute(opportunityWin["i9_pesquiso_site_empresa"]);
            }
            if (opportunityWin.Attributes.ContainsKey("i9_regiao"))
            {
                this.i9_regiao = GetValueAttribute(opportunityWin["i9_regiao"]);
            }
            if (opportunityWin.Attributes.ContainsKey("i9_retirou_duvidas_aderencia_software"))
            {
                this.i9_retirou_duvidas_aderencia_software = GetValueAttribute(opportunityWin["i9_retirou_duvidas_aderencia_software"]);
            }
            if (opportunityWin.Attributes.ContainsKey("i9_reuniao_decisores"))
            {
                this.i9_reuniao_decisores = GetValueAttribute(opportunityWin["i9_reuniao_decisores"]);
            }
            if (opportunityWin.Attributes.ContainsKey("i9_segmento_compativel"))
            {
                this.i9_segmento_compativel = GetValueAttribute(opportunityWin["i9_segmento_compativel"]);
            }
            if (opportunityWin.Attributes.ContainsKey("i9_segunda_reuniao"))
            {
                this.i9_segunda_reuniao = GetValueAttribute(opportunityWin["i9_segunda_reuniao"]);
            }
            if (opportunityWin.Attributes.ContainsKey("i9_solicitacao_desconto"))
            {
                this.i9_solicitacao_desconto = GetValueAttribute(opportunityWin["i9_solicitacao_desconto"]);
            }
            if (opportunityWin.Attributes.ContainsKey("i9_tabela_preco"))
            {
                this.i9_tabela_preco = GetValueAttribute(opportunityWin["i9_tabela_preco"]);
            }
            if (opportunityWin.Attributes.ContainsKey("i9_tempodefalha"))
            {
                this.i9_tempodefalha = GetValueAttribute(opportunityWin["i9_tempodefalha"]);
            }
            if (opportunityWin.Attributes.ContainsKey("i9_tempo_medio_abertura"))
            {
                this.i9_tempo_medio_abertura = GetValueAttribute(opportunityWin["i9_tempo_medio_abertura"]);
            }
            if (opportunityWin.Attributes.ContainsKey("i9_testandosoma"))
            {
                this.i9_testandosoma = GetValueAttribute(opportunityWin["i9_testandosoma"]);
            }
            if (opportunityWin.Attributes.ContainsKey("i9_unidade_negocio"))
            {
                this.i9_unidade_negocio = GetValueAttribute(opportunityWin["i9_unidade_negocio"]);
            }
            if (opportunityWin.Attributes.ContainsKey("i9_vice_presidente_desconto"))
            {
                this.i9_vice_presidente_desconto = GetValueAttribute(opportunityWin["i9_vice_presidente_desconto"]);
            }
            if (opportunityWin.Attributes.ContainsKey("i9_visita_agendada"))
            {
                this.i9_visita_agendada = GetValueAttribute(opportunityWin["i9_visita_agendada"]);
            }
            if (opportunityWin.Attributes.ContainsKey("identifycompetitors"))
            {
                this.identifycompetitors = GetValueAttribute(opportunityWin["identifycompetitors"]);
            }
            if (opportunityWin.Attributes.ContainsKey("identifycustomercontacts"))
            {
                this.identifycustomercontacts = GetValueAttribute(opportunityWin["identifycustomercontacts"]);
            }
            if (opportunityWin.Attributes.ContainsKey("identifypursuitteam"))
            {
                this.identifypursuitteam = GetValueAttribute(opportunityWin["identifypursuitteam"]);
            }
            if (opportunityWin.Attributes.ContainsKey("importsequencenumber"))
            {
                this.importsequencenumber = GetValueAttribute(opportunityWin["importsequencenumber"]);
            }
            if (opportunityWin.Attributes.ContainsKey("initialcommunication"))
            {
                this.initialcommunication = GetValueAttribute(opportunityWin["initialcommunication"]);
            }
            if (opportunityWin.Attributes.ContainsKey("isrevenuesystemcalculated"))
            {
                this.isrevenuesystemcalculated = GetValueAttribute(opportunityWin["isrevenuesystemcalculated"]);
            }
            if (opportunityWin.Attributes.ContainsKey("modifiedby"))
            {
                this.modifiedby = GetValueAttribute(opportunityWin["modifiedby"]);
            }
            if (opportunityWin.Attributes.ContainsKey("modifiedon"))
            {
                this.modifiedon = GetValueAttribute(opportunityWin["modifiedon"]);
            }
            if (opportunityWin.Attributes.ContainsKey("modifiedonbehalfby"))
            {
                this.modifiedonbehalfby = GetValueAttribute(opportunityWin["modifiedonbehalfby"]);
            }
            if (opportunityWin.Attributes.ContainsKey("name"))
            {
                this.name = GetValueAttribute(opportunityWin["name"]);
            }
            if (opportunityWin.Attributes.ContainsKey("need"))
            {
                this.need = GetValueAttribute(opportunityWin["need"]);
            }
            if (opportunityWin.Attributes.ContainsKey("new_cessodedireitodeusocdu"))
            {
                this.new_cessodedireitodeusocdu = GetValueAttribute(opportunityWin["new_cessodedireitodeusocdu"]);
            }
            if (opportunityWin.Attributes.ContainsKey("new_cronograma_ajustado"))
            {
                this.new_cronograma_ajustado = GetValueAttribute(opportunityWin["new_cronograma_ajustado"]);
            }
            if (opportunityWin.Attributes.ContainsKey("new_descrioparaimplantao"))
            {
                this.new_descrioparaimplantao = GetValueAttribute(opportunityWin["new_descrioparaimplantao"]);
            }
            if (opportunityWin.Attributes.ContainsKey("new_parceiro"))
            {
                this.new_parceiro = GetValueAttribute(opportunityWin["new_parceiro"]);
            }
            if (opportunityWin.Attributes.ContainsKey("opportunityid"))
            {
                this.opportunityid = GetValueAttribute(opportunityWin["opportunityid"]);
            }
            if (opportunityWin.Attributes.ContainsKey("opportunityratingcode"))
            {
                this.opportunityratingcode = GetValueAttribute(opportunityWin["opportunityratingcode"]);
            }
            if (opportunityWin.Attributes.ContainsKey("originatingleadid"))
            {
                this.originatingleadid = GetValueAttribute(opportunityWin["originatingleadid"]);
            }
            if (opportunityWin.Attributes.ContainsKey("overriddencreatedon"))
            {
                this.overriddencreatedon = GetValueAttribute(opportunityWin["overriddencreatedon"]);
            }
            if (opportunityWin.Attributes.ContainsKey("ownerid"))
            {
                this.ownerid = GetValueAttribute(opportunityWin["ownerid"]);
            }
            if (opportunityWin.Attributes.ContainsKey("owningbusinessunit"))
            {
                this.owningbusinessunit = GetValueAttribute(opportunityWin["owningbusinessunit"]);
            }
            if (opportunityWin.Attributes.ContainsKey("owningteam"))
            {
                this.owningteam = GetValueAttribute(opportunityWin["owningteam"]);
            }
            if (opportunityWin.Attributes.ContainsKey("owninguser"))
            {
                this.owninguser = GetValueAttribute(opportunityWin["owninguser"]);
            }
            if (opportunityWin.Attributes.ContainsKey("parentaccountid"))
            {
                this.parentaccountid = GetValueAttribute(opportunityWin["parentaccountid"]);
            }
            if (opportunityWin.Attributes.ContainsKey("parentcontactid"))
            {
                this.parentcontactid = GetValueAttribute(opportunityWin["parentcontactid"]);
            }
            if (opportunityWin.Attributes.ContainsKey("participatesinworkflow"))
            {
                this.participatesinworkflow = GetValueAttribute(opportunityWin["participatesinworkflow"]);
            }
            if (opportunityWin.Attributes.ContainsKey("presentfinalproposal"))
            {
                this.presentfinalproposal = GetValueAttribute(opportunityWin["presentfinalproposal"]);
            }
            if (opportunityWin.Attributes.ContainsKey("processid"))
            {
                this.processid = GetValueAttribute(opportunityWin["processid"]);
            }
            if (opportunityWin.Attributes.ContainsKey("proposedsolution"))
            {
                this.proposedsolution = GetValueAttribute(opportunityWin["proposedsolution"]);
            }
            if (opportunityWin.Attributes.ContainsKey("purchaseprocess"))
            {
                this.purchaseprocess = GetValueAttribute(opportunityWin["purchaseprocess"]);
            }
            if (opportunityWin.Attributes.ContainsKey("purchasetimeframe"))
            {
                this.purchasetimeframe = GetValueAttribute(opportunityWin["purchasetimeframe"]);
            }
            if (opportunityWin.Attributes.ContainsKey("pursuitdecision"))
            {
                this.pursuitdecision = GetValueAttribute(opportunityWin["pursuitdecision"]);
            }
            if (opportunityWin.Attributes.ContainsKey("qualificationcomments"))
            {
                this.qualificationcomments = GetValueAttribute(opportunityWin["qualificationcomments"]);
            }
            if (opportunityWin.Attributes.ContainsKey("quotecomments"))
            {
                this.quotecomments = GetValueAttribute(opportunityWin["quotecomments"]);
            }
            if (opportunityWin.Attributes.ContainsKey("resolvefeedback"))
            {
                this.resolvefeedback = GetValueAttribute(opportunityWin["resolvefeedback"]);
            }
            if (opportunityWin.Attributes.ContainsKey("salesstage"))
            {
                this.salesstage = GetValueAttribute(opportunityWin["salesstage"]);
            }
            if (opportunityWin.Attributes.ContainsKey("salesstagecode"))
            {
                this.salesstagecode = GetValueAttribute(opportunityWin["salesstagecode"]);
            }
            if (opportunityWin.Attributes.ContainsKey("schedulefollowup_prospect"))
            {
                this.schedulefollowup_prospect = GetValueAttribute(opportunityWin["schedulefollowup_prospect"]);
            }
            if (opportunityWin.Attributes.ContainsKey("schedulefollowup_qualify"))
            {
                this.schedulefollowup_qualify = GetValueAttribute(opportunityWin["schedulefollowup_qualify"]);
            }
            if (opportunityWin.Attributes.ContainsKey("scheduleproposalmeeting"))
            {
                this.scheduleproposalmeeting = GetValueAttribute(opportunityWin["scheduleproposalmeeting"]);
            }
            if (opportunityWin.Attributes.ContainsKey("sendthankyounote"))
            {
                this.sendthankyounote = GetValueAttribute(opportunityWin["sendthankyounote"]);
            }
            if (opportunityWin.Attributes.ContainsKey("stageid"))
            {
                this.stageid = GetValueAttribute(opportunityWin["stageid"]);
            }
            if (opportunityWin.Attributes.ContainsKey("statecode"))
            {
                this.statecode = GetValueAttribute(opportunityWin["statecode"]);
            }
            if (opportunityWin.Attributes.ContainsKey("statuscode"))
            {
                this.statuscode = GetValueAttribute(opportunityWin["statuscode"]);
            }
            if (opportunityWin.Attributes.ContainsKey("stepid"))
            {
                this.stepid = GetValueAttribute(opportunityWin["stepid"]);
            }
            if (opportunityWin.Attributes.ContainsKey("stepname"))
            {
                this.stepname = GetValueAttribute(opportunityWin["stepname"]);
            }
            if (opportunityWin.Attributes.ContainsKey("timeline"))
            {
                this.timeline = GetValueAttribute(opportunityWin["timeline"]);
            }
            if (opportunityWin.Attributes.ContainsKey("timezoneruleversionnumber"))
            {
                this.timezoneruleversionnumber = GetValueAttribute(opportunityWin["timezoneruleversionnumber"]);
            }
            if (opportunityWin.Attributes.ContainsKey("totalamount"))
            {
                this.totalamount = GetValueAttribute(opportunityWin["totalamount"]);
            }
            if (opportunityWin.Attributes.ContainsKey("totalamountlessfreight"))
            {
                this.totalamountlessfreight = GetValueAttribute(opportunityWin["totalamountlessfreight"]);
            }
            if (opportunityWin.Attributes.ContainsKey("totalamountlessfreight_base"))
            {
                this.totalamountlessfreight_base = GetValueAttribute(opportunityWin["totalamountlessfreight_base"]);
            }
            if (opportunityWin.Attributes.ContainsKey("totalamount_base"))
            {
                this.totalamount_base = GetValueAttribute(opportunityWin["totalamount_base"]);
            }
            if (opportunityWin.Attributes.ContainsKey("totaldiscountamount"))
            {
                this.totaldiscountamount = GetValueAttribute(opportunityWin["totaldiscountamount"]);
            }
            if (opportunityWin.Attributes.ContainsKey("totaldiscountamount_base"))
            {
                this.totaldiscountamount_base = GetValueAttribute(opportunityWin["totaldiscountamount_base"]);
            }
            if (opportunityWin.Attributes.ContainsKey("totallineitemamount"))
            {
                this.totallineitemamount = GetValueAttribute(opportunityWin["totallineitemamount"]);
            }
            if (opportunityWin.Attributes.ContainsKey("totallineitemamount_base"))
            {
                this.totallineitemamount_base = GetValueAttribute(opportunityWin["totallineitemamount_base"]);
            }
            if (opportunityWin.Attributes.ContainsKey("totallineitemdiscountamount"))
            {
                this.totallineitemdiscountamount = GetValueAttribute(opportunityWin["totallineitemdiscountamount"]);
            }
            if (opportunityWin.Attributes.ContainsKey("totallineitemdiscountamount_base"))
            {
                this.totallineitemdiscountamount_base = GetValueAttribute(opportunityWin["totallineitemdiscountamount_base"]);
            }
            if (opportunityWin.Attributes.ContainsKey("totaltax"))
            {
                this.totaltax = GetValueAttribute(opportunityWin["totaltax"]);
            }
            if (opportunityWin.Attributes.ContainsKey("totaltax_base"))
            {
                this.totaltax_base = GetValueAttribute(opportunityWin["totaltax_base"]);
            }
            if (opportunityWin.Attributes.ContainsKey("transactioncurrencyid"))
            {
                this.transactioncurrencyid = GetValueAttribute(opportunityWin["transactioncurrencyid"]);
            }
            if (opportunityWin.Attributes.ContainsKey("traversedpath"))
            {
                this.traversedpath = GetValueAttribute(opportunityWin["traversedpath"]);
            }
            if (opportunityWin.Attributes.ContainsKey("utcconversiontimezonecode"))
            {
                this.utcconversiontimezonecode = GetValueAttribute(opportunityWin["utcconversiontimezonecode"]);
            }
            if (opportunityWin.Attributes.ContainsKey("versionnumber"))
            {
                this.versionnumber = GetValueAttribute(opportunityWin["versionnumber"]);
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
