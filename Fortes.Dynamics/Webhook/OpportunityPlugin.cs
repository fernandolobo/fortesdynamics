using System;
using System.Runtime.Serialization;
using Microsoft.Xrm.Sdk;

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
                    this.actualvalue = Convert.ToString(((Money)opportunityWin["actualvalue"]).Value);
                }
                if (opportunityWin.Attributes.ContainsKey("actualvalue_base"))
                {
                    this.actualvalue_base = Convert.ToString(((Money)opportunityWin["actualvalue_base"]).Value);
                }
                if (opportunityWin.Attributes.ContainsKey("budgetamount"))
                {
                    this.budgetamount = Convert.ToString(((Money)opportunityWin["budgetamount"]).Value);
                }
                if (opportunityWin.Attributes.ContainsKey("budgetamount_base"))
                {
                    this.budgetamount_base = Convert.ToString(((Money)opportunityWin["budgetamount_base"]).Value);
                }
                if (opportunityWin.Attributes.ContainsKey("budgetstatus"))
                {
                    this.budgetstatus = opportunityWin["budgetstatus"].ToString();
                }
                if (opportunityWin.Attributes.ContainsKey("campaignid"))
                {
                    this.campaignid = opportunityWin["campaignid"].ToString();
                }

                //campaignid = opportunityWin["campaignid"].ToString();
                /*captureproposalfeedback = opportunityWin["captureproposalfeedback"].ToString();
                closeprobability = opportunityWin["closeprobability"].ToString();
                completefinalproposal = opportunityWin["completefinalproposal"].ToString();
                completeinternalreview = opportunityWin["completeinternalreview"].ToString();
                confirminterest = opportunityWin["confirminterest"].ToString();
                createdby = opportunityWin["createdby"].ToString();
                createdon = opportunityWin["createdon"].ToString();
                createdonbehalfby = opportunityWin["createdonbehalfby"].ToString();
                currentsituation = opportunityWin["currentsituation"].ToString();
                customerid = opportunityWin["customerid"].ToString();
                customerneed = opportunityWin["customerneed"].ToString();
                customerpainpoints = opportunityWin["customerpainpoints"].ToString();
                decisionmaker = opportunityWin["decisionmaker"].ToString();
                description = opportunityWin["description"].ToString();
                developproposal = opportunityWin["developproposal"].ToString();
                discountamount = opportunityWin["discountamount"].ToString();
                discountamount_base = opportunityWin["discountamount_base"].ToString();
                discountpercentage = opportunityWin["discountpercentage"].ToString();
                estimatedclosedate = opportunityWin["estimatedclosedate"].ToString();
                estimatedvalue = opportunityWin["estimatedvalue"].ToString();
                estimatedvalue_base = opportunityWin["estimatedvalue_base"].ToString();
                evaluatefit = opportunityWin["evaluatefit"].ToString();
                exchangerate = opportunityWin["exchangerate"].ToString();
                filedebrief = opportunityWin["filedebrief"].ToString();
                finaldecisiondate = opportunityWin["finaldecisiondate"].ToString();
                freightamount = opportunityWin["freightamount"].ToString();
                freightamount_base = opportunityWin["freightamount_base"].ToString();
                i9_antecipo_minuta_contrato = opportunityWin["i9_antecipo_minuta_contrato"].ToString();
                i9_case_sucesso = opportunityWin["i9_case_sucesso"].ToString();
                i9_descricao_pgto_adesao = opportunityWin["i9_descricao_pgto_adesao"].ToString();
                i9_descricao_pgto_ass_usuario = opportunityWin["i9_descricao_pgto_ass_usuario"].ToString();
                i9_descricao_pgto_atualizacao = opportunityWin["i9_descricao_pgto_atualizacao"].ToString();
                i9_descricao_pgto_customizacao = opportunityWin["i9_descricao_pgto_customizacao"].ToString();
                i9_descricao_pgto_implantacao = opportunityWin["i9_descricao_pgto_implantacao"].ToString();
                i9_descricao_pgto_manutencao = opportunityWin["i9_descricao_pgto_manutencao"].ToString();
                i9_descricao_pgto_venda = opportunityWin["i9_descricao_pgto_venda"].ToString();
                i9_forma_pgto_adesao = opportunityWin["i9_forma_pgto_adesao"].ToString();
                i9_forma_pgto_ass_por_usuario = opportunityWin["i9_forma_pgto_ass_por_usuario"].ToString();
                i9_forma_pgto_atualizacao = opportunityWin["i9_forma_pgto_atualizacao"].ToString();
                i9_forma_pgto_customizacao = opportunityWin["i9_forma_pgto_customizacao"].ToString();
                i9_forma_pgto_implantacao = opportunityWin["i9_forma_pgto_implantacao"].ToString();
                i9_forma_pgto_manutencao = opportunityWin["i9_forma_pgto_manutencao"].ToString();
                i9_forma_pgto_venda = opportunityWin["i9_forma_pgto_venda"].ToString();
                i9_gerente_desconto = opportunityWin["i9_gerente_desconto"].ToString();
                i9_ligacao_feita = opportunityWin["i9_ligacao_feita"].ToString();
                i9_origem = opportunityWin["i9_origem"].ToString();
                i9_origem_do_cliente = opportunityWin["i9_origem_do_cliente"].ToString();
                i9_patrocinadores_decisores = opportunityWin["i9_patrocinadores_decisores"].ToString();
                i9_pesquiso_site_empresa = opportunityWin["i9_pesquiso_site_empresa"].ToString();
                i9_regiao = opportunityWin["i9_regiao"].ToString();
                i9_retirou_duvidas_aderencia_software = opportunityWin["i9_retirou_duvidas_aderencia_software"].ToString();
                i9_reuniao_decisores = opportunityWin["i9_reuniao_decisores"].ToString();
                i9_segmento_compativel = opportunityWin["i9_segmento_compativel"].ToString();
                i9_segunda_reuniao = opportunityWin["i9_segunda_reuniao"].ToString();
                i9_solicitacao_desconto = opportunityWin["i9_solicitacao_desconto"].ToString();
                i9_tabela_preco = opportunityWin["i9_tabela_preco"].ToString();
                i9_tempodefalha = opportunityWin["i9_tempodefalha"].ToString();
                i9_tempo_medio_abertura = opportunityWin["i9_tempo_medio_abertura"].ToString();
                i9_testandosoma = opportunityWin["i9_testandosoma"].ToString();
                i9_unidade_negocio = opportunityWin["i9_unidade_negocio"].ToString();
                i9_vice_presidente_desconto = opportunityWin["i9_vice_presidente_desconto"].ToString();
                i9_visita_agendada = opportunityWin["i9_visita_agendada"].ToString();
                identifycompetitors = opportunityWin["identifycompetitors"].ToString();
                identifycustomercontacts = opportunityWin["identifycustomercontacts"].ToString();
                identifypursuitteam = opportunityWin["identifypursuitteam"].ToString();
                importsequencenumber = opportunityWin["importsequencenumber"].ToString();
                initialcommunication = opportunityWin["initialcommunication"].ToString();
                isrevenuesystemcalculated = opportunityWin["isrevenuesystemcalculated"].ToString();
                modifiedby = opportunityWin["modifiedby"].ToString();
                modifiedon = opportunityWin["modifiedon"].ToString();
                modifiedonbehalfby = opportunityWin["modifiedonbehalfby"].ToString();
                name = opportunityWin["name"].ToString();
                need = opportunityWin["need"].ToString();
                new_cessodedireitodeusocdu = opportunityWin["new_cessodedireitodeusocdu"].ToString();
                new_cronograma_ajustado = opportunityWin["new_cronograma_ajustado"].ToString();
                new_descrioparaimplantao = opportunityWin["new_descrioparaimplantao"].ToString();
                new_parceiro = opportunityWin["new_parceiro"].ToString();
                opportunityid = opportunityWin["opportunityid"].ToString();
                opportunityratingcode = opportunityWin["opportunityratingcode"].ToString();
                originatingleadid = opportunityWin["originatingleadid"].ToString();
                overriddencreatedon = opportunityWin["overriddencreatedon"].ToString();
                ownerid = opportunityWin["ownerid"].ToString();
                owningbusinessunit = opportunityWin["owningbusinessunit"].ToString();
                owningteam = opportunityWin["owningteam"].ToString();
                owninguser = opportunityWin["owninguser"].ToString();
                parentaccountid = opportunityWin["parentaccountid"].ToString();
                parentcontactid = opportunityWin["parentcontactid"].ToString();
                participatesinworkflow = opportunityWin["participatesinworkflow"].ToString();
                presentfinalproposal = opportunityWin["presentfinalproposal"].ToString();
                processid = opportunityWin["processid"].ToString();
                proposedsolution = opportunityWin["proposedsolution"].ToString();
                purchaseprocess = opportunityWin["purchaseprocess"].ToString();
                purchasetimeframe = opportunityWin["purchasetimeframe"].ToString();
                pursuitdecision = opportunityWin["pursuitdecision"].ToString();
                qualificationcomments = opportunityWin["qualificationcomments"].ToString();
                quotecomments = opportunityWin["quotecomments"].ToString();
                resolvefeedback = opportunityWin["resolvefeedback"].ToString();
                salesstage = opportunityWin["salesstage"].ToString();
                salesstagecode = opportunityWin["salesstagecode"].ToString();
                schedulefollowup_prospect = opportunityWin["schedulefollowup_prospect"].ToString();
                schedulefollowup_qualify = opportunityWin["schedulefollowup_qualify"].ToString();
                scheduleproposalmeeting = opportunityWin["scheduleproposalmeeting"].ToString();
                sendthankyounote = opportunityWin["sendthankyounote"].ToString();
                stageid = opportunityWin["stageid"].ToString();
                statecode = opportunityWin["statecode"].ToString();
                statuscode = opportunityWin["statuscode"].ToString();
                stepid = opportunityWin["stepid"].ToString();
                stepname = opportunityWin["stepname"].ToString();
                timeline = opportunityWin["timeline"].ToString();
                timezoneruleversionnumber = opportunityWin["timezoneruleversionnumber"].ToString();
                totalamount = opportunityWin["totalamount"].ToString();
                totalamountlessfreight = opportunityWin["totalamountlessfreight"].ToString();
                totalamountlessfreight_base = opportunityWin["totalamountlessfreight_base"].ToString();
                totalamount_base = opportunityWin["totalamount_base"].ToString();
                totaldiscountamount = opportunityWin["totaldiscountamount"].ToString();
                totaldiscountamount_base = opportunityWin["totaldiscountamount_base"].ToString();
                totallineitemamount = opportunityWin["totallineitemamount"].ToString();
                totallineitemamount_base = opportunityWin["totallineitemamount_base"].ToString();
                totallineitemdiscountamount = opportunityWin["totallineitemdiscountamount"].ToString();
                totallineitemdiscountamount_base = opportunityWin["totallineitemdiscountamount_base"].ToString();
                totaltax = opportunityWin["totaltax"].ToString();
                totaltax_base = opportunityWin["totaltax_base"].ToString();
                transactioncurrencyid = opportunityWin["transactioncurrencyid"].ToString();
                traversedpath = opportunityWin["traversedpath"].ToString();
                utcconversiontimezonecode = opportunityWin["utcconversiontimezonecode"].ToString();
                versionnumber = opportunityWin["versionnumber"].ToString();*/
            }
        }
    }
