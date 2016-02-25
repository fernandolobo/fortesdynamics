using Microsoft.Xrm.Sdk;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Webhook
{
    public class ProductOpportunityLocal
    {
        [DataMember]
        public string baseamount { get; set; }
        [DataMember]
        public string baseamount_base { get; set; }
        [DataMember]
        public string createdby { get; set; }
        [DataMember]
        public string createdon { get; set; }
        [DataMember]
        public string createdonbehalfby { get; set; }
        [DataMember]
        public string description { get; set; }
        [DataMember]
        public string entityimage { get; set; }
        [DataMember]
        public string exchangerate { get; set; }
        [DataMember]
        public string extendedamount { get; set; }
        [DataMember]
        public string extendedamount_base { get; set; }
        [DataMember]
        public string i9_autoriaza_doacao { get; set; }
        [DataMember]
        public string i9_aux_calculo_produto { get; set; }
        [DataMember]
        public string i9_avaliacao_desempenho { get; set; }
        [DataMember]
        public string i9_cargos_salarios { get; set; }
        [DataMember]
        public string i9_conceder_desconto { get; set; }
        [DataMember]
        public string i9_desconto { get; set; }
        [DataMember]
        public string i9_desconto1 { get; set; }
        [DataMember]
        public string i9_desconto2 { get; set; }
        [DataMember]
        public string i9_desconto3 { get; set; }
        [DataMember]
        public string i9_desconto4 { get; set; }
        [DataMember]
        public string i9_descricao_solicitacao { get; set; }
        [DataMember]
        public string i9_diretor { get; set; }
        [DataMember]
        public string i9_gerente { get; set; }
        [DataMember]
        public string i9_gerente_comercial { get; set; }
        [DataMember]
        public string i9_horas_franquia { get; set; }
        [DataMember]
        public string i9_lista_preco { get; set; }
        [DataMember]
        public string i9_modalidade1 { get; set; }
        [DataMember]
        public string i9_modalidade2 { get; set; }
        [DataMember]
        public string i9_modalidade3 { get; set; }
        [DataMember]
        public string i9_modalidade4 { get; set; }
        [DataMember]
        public string i9_modulo { get; set; }
        [DataMember]
        public string i9_perfil { get; set; }
        [DataMember]
        public string i9_pesquisa { get; set; }
        [DataMember]
        public string i9_porc_aumento_1 { get; set; }
        [DataMember]
        public string i9_porc_aumento_2 { get; set; }
        [DataMember]
        public string i9_porc_aumento_3 { get; set; }
        [DataMember]
        public string i9_porc_aumento_4 { get; set; }
        [DataMember]
        public string i9_porc_max_desconto { get; set; }
        [DataMember]
        public string i9_porcentagem_desconto { get; set; }
        [DataMember]
        public string i9_qtd_funcionario { get; set; }
        [DataMember]
        public string i9_qtd_modalidade1 { get; set; }
        [DataMember]
        public string i9_qtd_modalidade2 { get; set; }
        [DataMember]
        public string i9_qtd_modalidade3 { get; set; }
        [DataMember]
        public string i9_qtd_modalidade4 { get; set; }
        [DataMember]
        public string i9_qtd_modulos { get; set; }
        [DataMember]
        public string i9_qtd_usuario { get; set; }
        [DataMember]
        public string i9_recrut_selecao { get; set; }
        [DataMember]
        public string i9_sesmt { get; set; }
        [DataMember]
        public string i9_tab_ajuste_func_1 { get; set; }
        [DataMember]
        public string i9_tab_ajuste_func_2 { get; set; }
        [DataMember]
        public string i9_tab_ajuste_func_3 { get; set; }
        [DataMember]
        public string i9_tab_ajuste_func_4 { get; set; }
        [DataMember]
        public string i9_tab_ajuste_usuario_1 { get; set; }
        [DataMember]
        public string i9_tab_ajuste_usuario_2 { get; set; }
        [DataMember]
        public string i9_tab_ajuste_usuario_3 { get; set; }
        [DataMember]
        public string i9_tab_ajuste_usuario_4 { get; set; }
        [DataMember]
        public string i9_tabela_preco { get; set; }
        [DataMember]
        public string i9_trein_desenvolvimento { get; set; }
        [DataMember]
        public string i9_unidade_negocio { get; set; }
        [DataMember]
        public string i9_valor_com_desconto1 { get; set; }
        [DataMember]
        public string i9_valor_com_desconto1_base { get; set; }
        [DataMember]
        public string i9_valor_com_desconto2 { get; set; }
        [DataMember]
        public string i9_valor_com_desconto2_base { get; set; }
        [DataMember]
        public string i9_valor_com_desconto3 { get; set; }
        [DataMember]
        public string i9_valor_com_desconto3_base { get; set; }
        [DataMember]
        public string i9_valor_com_desconto4 { get; set; }
        [DataMember]
        public string i9_valor_com_desconto4_base { get; set; }
        [DataMember]
        public string i9_valor1 { get; set; }
        [DataMember]
        public string i9_valor1_base { get; set; }
        [DataMember]
        public string i9_valor2 { get; set; }
        [DataMember]
        public string i9_valor2_base { get; set; }
        [DataMember]
        public string i9_valor3 { get; set; }
        [DataMember]
        public string i9_valor3_base { get; set; }
        [DataMember]
        public string i9_valor4 { get; set; }
        [DataMember]
        public string i9_valor4_base { get; set; }
        [DataMember]
        public string i9_visualizar_ajustes { get; set; }
        [DataMember]
        public string importsequencenumber { get; set; }
        [DataMember]
        public string ispriceoverridden { get; set; }
        [DataMember]
        public string isproductoverridden { get; set; }
        [DataMember]
        public string lineitemnumber { get; set; }
        [DataMember]
        public string manualdiscountamount { get; set; }
        [DataMember]
        public string manualdiscountamount_base { get; set; }
        [DataMember]
        public string modifiedby { get; set; }
        [DataMember]
        public string modifiedon { get; set; }
        [DataMember]
        public string modifiedonbehalfby { get; set; }
        [DataMember]
        public string new_produtodaoportunidadeid { get; set; }
        [DataMember]
        public string opportunityid { get; set; }
        [DataMember]
        public string opportunityproductid { get; set; }
        [DataMember]
        public string opportunitystatecode { get; set; }
        [DataMember]
        public string overriddencreatedon { get; set; }
        [DataMember]
        public string ownerid { get; set; }
        [DataMember]
        public string owningbusinessunit { get; set; }
        [DataMember]
        public string owninguser { get; set; }
        [DataMember]
        public string parentbundleid { get; set; }
        [DataMember]
        public string priceperunit { get; set; }
        [DataMember]
        public string priceperunit_base { get; set; }
        [DataMember]
        public string pricingerrorcode { get; set; }
        [DataMember]
        public string productassociationid { get; set; }
        [DataMember]
        public string productdescription { get; set; }
        [DataMember]
        public string productid { get; set; }
        [DataMember]
        public string producttypecode { get; set; }
        [DataMember]
        public string propertyconfigurationstatus { get; set; }
        [DataMember]
        public string quantity { get; set; }
        [DataMember]
        public string sequencenumber { get; set; }
        [DataMember]
        public string tax { get; set; }
        [DataMember]
        public string tax_base { get; set; }
        [DataMember]
        public string timezoneruleversionnumber { get; set; }
        [DataMember]
        public string transactioncurrencyid { get; set; }
        [DataMember]
        public string uomid { get; set; }
        [DataMember]
        public string utcconversiontimezonecode { get; set; }
        [DataMember]
        public string versionnumber { get; set; }
        [DataMember]
        public string volumediscountamount { get; set; }
        [DataMember]
        public string volumediscountamount_base { get; set; }

        public ProductOpportunityLocal() { }

        public void SetProductOpportunityLocal(Entity productOpportunityWin)
        {
            if (productOpportunityWin.Attributes.ContainsKey("baseamount"))
            {
                this.baseamount = productOpportunityWin["baseamount"].ToString();
            }
            if (productOpportunityWin.Attributes.ContainsKey("baseamount_base"))
            {
                this.baseamount_base = productOpportunityWin["baseamount_base"].ToString();
            }
            if (productOpportunityWin.Attributes.ContainsKey("createdby"))
            {
                this.createdby = productOpportunityWin["createdby"].ToString();
            }
            if (productOpportunityWin.Attributes.ContainsKey("createdon"))
            {
                this.createdon = productOpportunityWin["createdon"].ToString();
            }
            if (productOpportunityWin.Attributes.ContainsKey("createdonbehalfby"))
            {
                this.createdonbehalfby = productOpportunityWin["createdonbehalfby"].ToString();
            }
            if (productOpportunityWin.Attributes.ContainsKey("description"))
            {
                this.description = productOpportunityWin["description"].ToString();
            }
            if (productOpportunityWin.Attributes.ContainsKey(""))
            {
                this.entityimage = productOpportunityWin["entityimage"].ToString();
            }
            if (productOpportunityWin.Attributes.ContainsKey("exchangerate"))
            {
                this.exchangerate = productOpportunityWin["exchangerate"].ToString();
            }
            if (productOpportunityWin.Attributes.ContainsKey("extendedamount"))
            {
                this.extendedamount = productOpportunityWin["extendedamount"].ToString();
            }
            if (productOpportunityWin.Attributes.ContainsKey("extendedamount_base"))
            {
                this.extendedamount_base = productOpportunityWin["extendedamount_base"].ToString();
            }
            if (productOpportunityWin.Attributes.ContainsKey("i9_autoriaza_doacao"))
            {
                this.i9_autoriaza_doacao = productOpportunityWin["i9_autoriaza_doacao"].ToString();
            }
            if (productOpportunityWin.Attributes.ContainsKey("i9_aux_calculo_produto"))
            {
                this.i9_aux_calculo_produto = productOpportunityWin["i9_aux_calculo_produto"].ToString();
            }
            if (productOpportunityWin.Attributes.ContainsKey("i9_avaliacao_desempenho"))
            {
                this.i9_avaliacao_desempenho = productOpportunityWin["i9_avaliacao_desempenho"].ToString();
            }
            if (productOpportunityWin.Attributes.ContainsKey("i9_cargos_salarios"))
            {
                this.i9_cargos_salarios = productOpportunityWin["i9_cargos_salarios"].ToString();
            }
            if (productOpportunityWin.Attributes.ContainsKey("i9_conceder_desconto"))
            {
                this.i9_conceder_desconto = productOpportunityWin["i9_conceder_desconto"].ToString();
            }
            if (productOpportunityWin.Attributes.ContainsKey("i9_desconto"))
            {
                this.i9_desconto = productOpportunityWin["i9_desconto"].ToString();
            }
            if (productOpportunityWin.Attributes.ContainsKey("i9_desconto1"))
            {
                this.i9_desconto1 = productOpportunityWin["i9_desconto1"].ToString();
            }
            if (productOpportunityWin.Attributes.ContainsKey("i9_desconto2"))
            {
                this.i9_desconto2 = productOpportunityWin["i9_desconto2"].ToString();
            }
            if (productOpportunityWin.Attributes.ContainsKey("i9_desconto3"))
            {
                this.i9_desconto3 = productOpportunityWin["i9_desconto3"].ToString();
            }
            if (productOpportunityWin.Attributes.ContainsKey("i9_desconto4"))
            {
                this.i9_desconto4 = productOpportunityWin["i9_desconto4"].ToString();
            }
            if (productOpportunityWin.Attributes.ContainsKey("i9_descricao_solicitacao"))
            {
                this.i9_descricao_solicitacao = productOpportunityWin["i9_descricao_solicitacao"].ToString();
            }
            if (productOpportunityWin.Attributes.ContainsKey("i9_diretor"))
            {
                this.i9_diretor = productOpportunityWin["i9_diretor"].ToString();
            }
            if (productOpportunityWin.Attributes.ContainsKey("i9_gerente"))
            {
                this.i9_gerente = productOpportunityWin["i9_gerente"].ToString();
            }
            if (productOpportunityWin.Attributes.ContainsKey("i9_gerente_comercial"))
            {
                this.i9_gerente_comercial = productOpportunityWin["i9_gerente_comercial"].ToString();
            }
            if (productOpportunityWin.Attributes.ContainsKey("i9_horas_franquia"))
            {
                this.i9_horas_franquia = productOpportunityWin["i9_horas_franquia"].ToString();
            }
            if (productOpportunityWin.Attributes.ContainsKey("i9_lista_preco"))
            {
                this.i9_lista_preco = productOpportunityWin["i9_lista_preco"].ToString();
            }
            if (productOpportunityWin.Attributes.ContainsKey("i9_modalidade1"))
            {
                this.i9_modalidade1 = productOpportunityWin["i9_modalidade1"].ToString();
            }
            if (productOpportunityWin.Attributes.ContainsKey("i9_modalidade2"))
            {
                this.i9_modalidade2 = productOpportunityWin["i9_modalidade2"].ToString();
            }
            if (productOpportunityWin.Attributes.ContainsKey("i9_modalidade3"))
            {
                this.i9_modalidade3 = productOpportunityWin["i9_modalidade3"].ToString();
            }
            if (productOpportunityWin.Attributes.ContainsKey("i9_modalidade4"))
            {
                this.i9_modalidade4 = productOpportunityWin["i9_modalidade4"].ToString();
            }
            if (productOpportunityWin.Attributes.ContainsKey("i9_modulo"))
            {
                this.i9_modulo = productOpportunityWin["i9_modulo"].ToString();
            }
            if (productOpportunityWin.Attributes.ContainsKey("i9_perfil"))
            {
                this.i9_perfil = productOpportunityWin["i9_perfil"].ToString();
            }
            if (productOpportunityWin.Attributes.ContainsKey("i9_pesquisa"))
            {
                this.i9_pesquisa = productOpportunityWin["i9_pesquisa"].ToString();
            }
            if (productOpportunityWin.Attributes.ContainsKey("i9_porc_aumento_1"))
            {
                this.i9_porc_aumento_1 = productOpportunityWin["i9_porc_aumento_1"].ToString();
            }
            if (productOpportunityWin.Attributes.ContainsKey("i9_porc_aumento_2"))
            {
                this.i9_porc_aumento_2 = productOpportunityWin["i9_porc_aumento_2"].ToString();
            }
            if (productOpportunityWin.Attributes.ContainsKey("i9_porc_aumento_3"))
            {
                this.i9_porc_aumento_3 = productOpportunityWin["i9_porc_aumento_3"].ToString();
            }
            if (productOpportunityWin.Attributes.ContainsKey("i9_porc_aumento_4"))
            {
                this.i9_porc_aumento_4 = productOpportunityWin["i9_porc_aumento_4"].ToString();
            }
            if (productOpportunityWin.Attributes.ContainsKey("i9_porc_max_desconto"))
            {
                this.i9_porc_max_desconto = productOpportunityWin["i9_porc_max_desconto"].ToString();
            }
            if (productOpportunityWin.Attributes.ContainsKey("i9_porcentagem_desconto"))
            {
                this.i9_porcentagem_desconto = productOpportunityWin["i9_porcentagem_desconto"].ToString();
            }
            if (productOpportunityWin.Attributes.ContainsKey("i9_qtd_funcionario"))
            {
                this.i9_qtd_funcionario = productOpportunityWin["i9_qtd_funcionario"].ToString();
            }
            if (productOpportunityWin.Attributes.ContainsKey("i9_qtd_modalidade1"))
            {
                this.i9_qtd_modalidade1 = productOpportunityWin["i9_qtd_modalidade1"].ToString();
            }
            if (productOpportunityWin.Attributes.ContainsKey("i9_qtd_modalidade2"))
            {
                this.i9_qtd_modalidade2 = productOpportunityWin["i9_qtd_modalidade2"].ToString();
            }
            if (productOpportunityWin.Attributes.ContainsKey("i9_qtd_modalidade3"))
            {
                this.i9_qtd_modalidade3 = productOpportunityWin["i9_qtd_modalidade3"].ToString();
            }
            if (productOpportunityWin.Attributes.ContainsKey("i9_qtd_modalidade4"))
            {
                this.i9_qtd_modalidade4 = productOpportunityWin["i9_qtd_modalidade4"].ToString();
            }
            if (productOpportunityWin.Attributes.ContainsKey("i9_qtd_modulos"))
            {
                this.i9_qtd_modulos = productOpportunityWin["i9_qtd_modulos"].ToString();
            }
            if (productOpportunityWin.Attributes.ContainsKey("i9_qtd_usuario"))
            {
                this.i9_qtd_usuario = productOpportunityWin["i9_qtd_usuario"].ToString();
            }
            if (productOpportunityWin.Attributes.ContainsKey("i9_recrut_selecao"))
            {
                this.i9_recrut_selecao = productOpportunityWin["i9_recrut_selecao"].ToString();
            }
            if (productOpportunityWin.Attributes.ContainsKey("i9_sesmt"))
            {
                this.i9_sesmt = productOpportunityWin["i9_sesmt"].ToString();
            }
            if (productOpportunityWin.Attributes.ContainsKey("i9_tab_ajuste_func_1"))
            {
                this.i9_tab_ajuste_func_1 = productOpportunityWin["i9_tab_ajuste_func_1"].ToString();
            }
            if (productOpportunityWin.Attributes.ContainsKey("i9_tab_ajuste_func_2"))
            {
                this.i9_tab_ajuste_func_2 = productOpportunityWin["i9_tab_ajuste_func_2"].ToString();
            }
            if (productOpportunityWin.Attributes.ContainsKey("i9_tab_ajuste_func_3"))
            {
                this.i9_tab_ajuste_func_3 = productOpportunityWin["i9_tab_ajuste_func_3"].ToString();
            }
            if (productOpportunityWin.Attributes.ContainsKey("i9_tab_ajuste_func_4"))
            {
                this.i9_tab_ajuste_func_4 = productOpportunityWin["i9_tab_ajuste_func_4"].ToString();
            }
            if (productOpportunityWin.Attributes.ContainsKey("i9_tab_ajuste_usuario_1"))
            {
                this.i9_tab_ajuste_usuario_1 = productOpportunityWin["i9_tab_ajuste_usuario_1"].ToString();
            }
            if (productOpportunityWin.Attributes.ContainsKey("i9_tab_ajuste_usuario_2"))
            {
                this.i9_tab_ajuste_usuario_2 = productOpportunityWin["i9_tab_ajuste_usuario_2"].ToString();
            }
            if (productOpportunityWin.Attributes.ContainsKey("i9_tab_ajuste_usuario_3"))
            {
                this.i9_tab_ajuste_usuario_3 = productOpportunityWin["i9_tab_ajuste_usuario_3"].ToString();
            }
            if (productOpportunityWin.Attributes.ContainsKey("i9_tab_ajuste_usuario_4"))
            {
                this.i9_tab_ajuste_usuario_4 = productOpportunityWin["i9_tab_ajuste_usuario_4"].ToString();
            }
            if (productOpportunityWin.Attributes.ContainsKey("i9_tabela_preco"))
            {
                this.i9_tabela_preco = productOpportunityWin["i9_tabela_preco"].ToString();
            }
            if (productOpportunityWin.Attributes.ContainsKey("i9_trein_desenvolvimento"))
            {
                this.i9_trein_desenvolvimento = productOpportunityWin["i9_trein_desenvolvimento"].ToString();
            }
            if (productOpportunityWin.Attributes.ContainsKey("i9_unidade_negocio"))
            {
                this.i9_unidade_negocio = productOpportunityWin["i9_unidade_negocio"].ToString();
            }
            if (productOpportunityWin.Attributes.ContainsKey("i9_valor_com_desconto1"))
            {
                this.i9_valor_com_desconto1 = productOpportunityWin["i9_valor_com_desconto1"].ToString();
            }
            if (productOpportunityWin.Attributes.ContainsKey("i9_valor_com_desconto1_base"))
            {
                this.i9_valor_com_desconto1_base = productOpportunityWin["i9_valor_com_desconto1_base"].ToString();
            }
            if (productOpportunityWin.Attributes.ContainsKey("i9_valor_com_desconto2"))
            {
                this.i9_valor_com_desconto2 = productOpportunityWin["i9_valor_com_desconto2"].ToString();
            }
            if (productOpportunityWin.Attributes.ContainsKey("i9_valor_com_desconto2_base"))
            {
                this.i9_valor_com_desconto2_base = productOpportunityWin["i9_valor_com_desconto2_base"].ToString();
            }
            if (productOpportunityWin.Attributes.ContainsKey("i9_valor_com_desconto3"))
            {
                this.i9_valor_com_desconto3 = productOpportunityWin["i9_valor_com_desconto3"].ToString();
            }
            if (productOpportunityWin.Attributes.ContainsKey("i9_valor_com_desconto3_base"))
            {
                this.i9_valor_com_desconto3_base = productOpportunityWin["i9_valor_com_desconto3_base"].ToString();
            }
            if (productOpportunityWin.Attributes.ContainsKey("i9_valor_com_desconto4"))
            {
                this.i9_valor_com_desconto4 = productOpportunityWin["i9_valor_com_desconto4"].ToString();
            }
            if (productOpportunityWin.Attributes.ContainsKey("i9_valor_com_desconto4_base"))
            {
                this.i9_valor_com_desconto4_base = productOpportunityWin["i9_valor_com_desconto4_base"].ToString();
            }
            if (productOpportunityWin.Attributes.ContainsKey("i9_valor1"))
            {
                this.i9_valor1 = productOpportunityWin["i9_valor1"].ToString();
            }
            if (productOpportunityWin.Attributes.ContainsKey("i9_valor1_base"))
            {
                this.i9_valor1_base = productOpportunityWin["i9_valor1_base"].ToString();
            }
            if (productOpportunityWin.Attributes.ContainsKey("i9_valor2"))
            {
                this.i9_valor2 = productOpportunityWin["i9_valor2"].ToString();
            }
            if (productOpportunityWin.Attributes.ContainsKey("i9_valor2_base"))
            {
                this.i9_valor2_base = productOpportunityWin["i9_valor2_base"].ToString();
            }
            if (productOpportunityWin.Attributes.ContainsKey("i9_valor3"))
            {
                this.i9_valor3 = productOpportunityWin["i9_valor3"].ToString();
            }
            if (productOpportunityWin.Attributes.ContainsKey("i9_valor3_base"))
            {
                this.i9_valor3_base = productOpportunityWin["i9_valor3_base"].ToString();
            }
            if (productOpportunityWin.Attributes.ContainsKey("i9_valor4"))
            {
                this.i9_valor4 = productOpportunityWin["i9_valor4"].ToString();
            }
            if (productOpportunityWin.Attributes.ContainsKey("i9_valor4_base"))
            {
                this.i9_valor4_base = productOpportunityWin["i9_valor4_base"].ToString();
            }
            if (productOpportunityWin.Attributes.ContainsKey("i9_visualizar_ajustes"))
            {
                this.i9_visualizar_ajustes = productOpportunityWin["i9_visualizar_ajustes"].ToString();
            }
            if (productOpportunityWin.Attributes.ContainsKey("importsequencenumber"))
            {
                this.importsequencenumber = productOpportunityWin["importsequencenumber"].ToString();
            }
            if (productOpportunityWin.Attributes.ContainsKey("ispriceoverridden"))
            {
                this.ispriceoverridden = productOpportunityWin["ispriceoverridden"].ToString();
            }
            if (productOpportunityWin.Attributes.ContainsKey("isproductoverridden"))
            {
                this.isproductoverridden = productOpportunityWin["isproductoverridden"].ToString();
            }
            if (productOpportunityWin.Attributes.ContainsKey("lineitemnumber"))
            {
                this.lineitemnumber = productOpportunityWin["lineitemnumber"].ToString();
            }
            if (productOpportunityWin.Attributes.ContainsKey("manualdiscountamount"))
            {
                this.manualdiscountamount = productOpportunityWin["manualdiscountamount"].ToString();
            }
            if (productOpportunityWin.Attributes.ContainsKey("manualdiscountamount_base"))
            {
                this.manualdiscountamount_base = productOpportunityWin["manualdiscountamount_base"].ToString();
            }
            if (productOpportunityWin.Attributes.ContainsKey("modifiedby"))
            {
                this.modifiedby = productOpportunityWin["modifiedby"].ToString();
            }
            if (productOpportunityWin.Attributes.ContainsKey("modifiedon"))
            {
                this.modifiedon = productOpportunityWin["modifiedon"].ToString();
            }
            if (productOpportunityWin.Attributes.ContainsKey("modifiedonbehalfby"))
            {
                this.modifiedonbehalfby = productOpportunityWin["modifiedonbehalfby"].ToString();
            }
            if (productOpportunityWin.Attributes.ContainsKey("new_produtodaoportunidadeid"))
            {
                this.new_produtodaoportunidadeid = productOpportunityWin["new_produtodaoportunidadeid"].ToString();
            }
            if (productOpportunityWin.Attributes.ContainsKey("opportunityid"))
            {
                this.opportunityid = productOpportunityWin["opportunityid"].ToString();
            }
            if (productOpportunityWin.Attributes.ContainsKey("opportunityproductid"))
            {
                this.opportunityproductid = productOpportunityWin["opportunityproductid"].ToString();
            }
            if (productOpportunityWin.Attributes.ContainsKey("opportunitystatecode"))
            {
                this.opportunitystatecode = productOpportunityWin["opportunitystatecode"].ToString();
            }
            if (productOpportunityWin.Attributes.ContainsKey("overriddencreatedon"))
            {
                this.overriddencreatedon = productOpportunityWin["overriddencreatedon"].ToString();
            }
            if (productOpportunityWin.Attributes.ContainsKey("ownerid"))
            {
                this.ownerid = productOpportunityWin["ownerid"].ToString();
            }
            if (productOpportunityWin.Attributes.ContainsKey("owningbusinessunit"))
            {
                this.owningbusinessunit = productOpportunityWin["owningbusinessunit"].ToString();
            }
            if (productOpportunityWin.Attributes.ContainsKey("owninguser"))
            {
                this.owninguser = productOpportunityWin["owninguser"].ToString();
            }
            if (productOpportunityWin.Attributes.ContainsKey("parentbundleid"))
            {
                this.parentbundleid = productOpportunityWin["parentbundleid"].ToString();
            }
            if (productOpportunityWin.Attributes.ContainsKey("priceperunit"))
            {
                this.priceperunit = productOpportunityWin["priceperunit"].ToString();
            }
            if (productOpportunityWin.Attributes.ContainsKey("priceperunit_base"))
            {
                this.priceperunit_base = productOpportunityWin["priceperunit_base"].ToString();
            }
            if (productOpportunityWin.Attributes.ContainsKey("pricingerrorcode"))
            {
                this.pricingerrorcode = productOpportunityWin["pricingerrorcode"].ToString();
            }
            if (productOpportunityWin.Attributes.ContainsKey("productassociationid"))
            {
                this.productassociationid = productOpportunityWin["productassociationid"].ToString();
            }
            if (productOpportunityWin.Attributes.ContainsKey("productdescription"))
            {
                this.productdescription = productOpportunityWin["productdescription"].ToString();
            }
            if (productOpportunityWin.Attributes.ContainsKey("productid"))
            {
                this.productid = productOpportunityWin["productid"].ToString();
            }
            if (productOpportunityWin.Attributes.ContainsKey("producttypecode"))
            {
                this.producttypecode = productOpportunityWin["producttypecode"].ToString();
            }
            if (productOpportunityWin.Attributes.ContainsKey("propertyconfigurationstatus"))
            {
                this.propertyconfigurationstatus = productOpportunityWin["propertyconfigurationstatus"].ToString();
            }
            if (productOpportunityWin.Attributes.ContainsKey("quantity"))
            {
                this.quantity = productOpportunityWin["quantity"].ToString();
            }
            if (productOpportunityWin.Attributes.ContainsKey("sequencenumber"))
            {
                this.sequencenumber = productOpportunityWin["sequencenumber"].ToString();
            }
            if (productOpportunityWin.Attributes.ContainsKey("tax"))
            {
                this.tax = productOpportunityWin["tax"].ToString();
            }
            if (productOpportunityWin.Attributes.ContainsKey("tax_base"))
            {
                this.tax_base = productOpportunityWin["tax_base"].ToString();
            }
            if (productOpportunityWin.Attributes.ContainsKey("timezoneruleversionnumber"))
            {
                this.timezoneruleversionnumber = productOpportunityWin["timezoneruleversionnumber"].ToString();
            }
            if (productOpportunityWin.Attributes.ContainsKey("transactioncurrencyid"))
            {
                this.transactioncurrencyid = productOpportunityWin["transactioncurrencyid"].ToString();
            }
            if (productOpportunityWin.Attributes.ContainsKey("uomid"))
            {
                this.uomid = productOpportunityWin["uomid"].ToString();
            }
            if (productOpportunityWin.Attributes.ContainsKey("utcconversiontimezonecode"))
            {
                this.utcconversiontimezonecode = productOpportunityWin["utcconversiontimezonecode"].ToString();
            }
            if (productOpportunityWin.Attributes.ContainsKey("versionnumber"))
            {
                this.versionnumber = productOpportunityWin["versionnumber"].ToString();
            }
            if (productOpportunityWin.Attributes.ContainsKey("volumediscountamount"))
            {
                this.volumediscountamount = productOpportunityWin["volumediscountamount"].ToString();
            }
            if (productOpportunityWin.Attributes.ContainsKey("volumediscountamount_base"))
            {
                this.volumediscountamount_base = productOpportunityWin["volumediscountamount_base"].ToString();
            }
        }
    }
}
