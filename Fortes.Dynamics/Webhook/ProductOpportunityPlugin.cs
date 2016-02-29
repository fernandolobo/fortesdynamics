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
                this.baseamount = GetValueAttribute(productOpportunityWin["baseamount"]);
            }
            if (productOpportunityWin.Attributes.ContainsKey("baseamount_base"))
            {
                this.baseamount_base = GetValueAttribute(productOpportunityWin["baseamount_base"]);
            }
            if (productOpportunityWin.Attributes.ContainsKey("createdby"))
            {
                this.createdby = GetValueAttribute(productOpportunityWin["createdby"]);
            }
            if (productOpportunityWin.Attributes.ContainsKey("createdon"))
            {
                this.createdon = GetValueAttribute(productOpportunityWin["createdon"]);
            }
            if (productOpportunityWin.Attributes.ContainsKey("createdonbehalfby"))
            {
                this.createdonbehalfby = GetValueAttribute(productOpportunityWin["createdonbehalfby"]);
            }
            if (productOpportunityWin.Attributes.ContainsKey("description"))
            {
                this.description = GetValueAttribute(productOpportunityWin["description"]);
            }
            if (productOpportunityWin.Attributes.ContainsKey("entityimage"))
            {
                this.entityimage = GetValueAttribute(productOpportunityWin["entityimage"]);
            }
            if (productOpportunityWin.Attributes.ContainsKey("exchangerate"))
            {
                this.exchangerate = GetValueAttribute(productOpportunityWin["exchangerate"]);
            }
            if (productOpportunityWin.Attributes.ContainsKey("extendedamount"))
            {
                this.extendedamount = GetValueAttribute(productOpportunityWin["extendedamount"]);
            }
            if (productOpportunityWin.Attributes.ContainsKey("extendedamount_base"))
            {
                this.extendedamount_base = GetValueAttribute(productOpportunityWin["extendedamount_base"]);
            }
            if (productOpportunityWin.Attributes.ContainsKey("i9_autoriaza_doacao"))
            {
                this.i9_autoriaza_doacao = GetValueAttribute(productOpportunityWin["i9_autoriaza_doacao"]);
            }
            if (productOpportunityWin.Attributes.ContainsKey("i9_aux_calculo_produto"))
            {
                this.i9_aux_calculo_produto = GetValueAttribute(productOpportunityWin["i9_aux_calculo_produto"]);
            }
            if (productOpportunityWin.Attributes.ContainsKey("i9_avaliacao_desempenho"))
            {
                this.i9_avaliacao_desempenho = GetValueAttribute(productOpportunityWin["i9_avaliacao_desempenho"]);
            }
            if (productOpportunityWin.Attributes.ContainsKey("i9_cargos_salarios"))
            {
                this.i9_cargos_salarios = GetValueAttribute(productOpportunityWin["i9_cargos_salarios"]);
            }
            if (productOpportunityWin.Attributes.ContainsKey("i9_conceder_desconto"))
            {
                this.i9_conceder_desconto = GetValueAttribute(productOpportunityWin["i9_conceder_desconto"]);
            }
            if (productOpportunityWin.Attributes.ContainsKey("i9_desconto"))
            {
                this.i9_desconto = GetValueAttribute(productOpportunityWin["i9_desconto"]);
            }
            if (productOpportunityWin.Attributes.ContainsKey("i9_desconto1"))
            {
                this.i9_desconto1 = GetValueAttribute(productOpportunityWin["i9_desconto1"]);
            }
            if (productOpportunityWin.Attributes.ContainsKey("i9_desconto2"))
            {
                this.i9_desconto2 = GetValueAttribute(productOpportunityWin["i9_desconto2"]);
            }
            if (productOpportunityWin.Attributes.ContainsKey("i9_desconto3"))
            {
                this.i9_desconto3 = GetValueAttribute(productOpportunityWin["i9_desconto3"]);
            }
            if (productOpportunityWin.Attributes.ContainsKey("i9_desconto4"))
            {
                this.i9_desconto4 = GetValueAttribute(productOpportunityWin["i9_desconto4"]);
            }
            if (productOpportunityWin.Attributes.ContainsKey("i9_descricao_solicitacao"))
            {
                this.i9_descricao_solicitacao = GetValueAttribute(productOpportunityWin["i9_descricao_solicitacao"]);
            }
            if (productOpportunityWin.Attributes.ContainsKey("i9_diretor"))
            {
                this.i9_diretor = GetValueAttribute(productOpportunityWin["i9_diretor"]);
            }
            if (productOpportunityWin.Attributes.ContainsKey("i9_gerente"))
            {
                this.i9_gerente = GetValueAttribute(productOpportunityWin["i9_gerente"]);
            }
            if (productOpportunityWin.Attributes.ContainsKey("i9_gerente_comercial"))
            {
                this.i9_gerente_comercial = GetValueAttribute(productOpportunityWin["i9_gerente_comercial"]);
            }
            if (productOpportunityWin.Attributes.ContainsKey("i9_horas_franquia"))
            {
                this.i9_horas_franquia = GetValueAttribute(productOpportunityWin["i9_horas_franquia"]);
            }
            if (productOpportunityWin.Attributes.ContainsKey("i9_lista_preco"))
            {
                this.i9_lista_preco = GetValueAttribute(productOpportunityWin["i9_lista_preco"]);
            }
            if (productOpportunityWin.Attributes.ContainsKey("i9_modalidade1"))
            {
                this.i9_modalidade1 = GetValueAttribute(productOpportunityWin["i9_modalidade1"]);
            }
            if (productOpportunityWin.Attributes.ContainsKey("i9_modalidade2"))
            {
                this.i9_modalidade2 = GetValueAttribute(productOpportunityWin["i9_modalidade2"]);
            }
            if (productOpportunityWin.Attributes.ContainsKey("i9_modalidade3"))
            {
                this.i9_modalidade3 = GetValueAttribute(productOpportunityWin["i9_modalidade3"]);
            }
            if (productOpportunityWin.Attributes.ContainsKey("i9_modalidade4"))
            {
                this.i9_modalidade4 = GetValueAttribute(productOpportunityWin["i9_modalidade4"]);
            }
            if (productOpportunityWin.Attributes.ContainsKey("i9_modulo"))
            {
                this.i9_modulo = GetValueAttribute(productOpportunityWin["i9_modulo"]);
            }
            if (productOpportunityWin.Attributes.ContainsKey("i9_perfil"))
            {
                this.i9_perfil = GetValueAttribute(productOpportunityWin["i9_perfil"]);
            }
            if (productOpportunityWin.Attributes.ContainsKey("i9_pesquisa"))
            {
                this.i9_pesquisa = GetValueAttribute(productOpportunityWin["i9_pesquisa"]);
            }
            if (productOpportunityWin.Attributes.ContainsKey("i9_porc_aumento_1"))
            {
                this.i9_porc_aumento_1 = GetValueAttribute(productOpportunityWin["i9_porc_aumento_1"]);
            }
            if (productOpportunityWin.Attributes.ContainsKey("i9_porc_aumento_2"))
            {
                this.i9_porc_aumento_2 = GetValueAttribute(productOpportunityWin["i9_porc_aumento_2"]);
            }
            if (productOpportunityWin.Attributes.ContainsKey("i9_porc_aumento_3"))
            {
                this.i9_porc_aumento_3 = GetValueAttribute(productOpportunityWin["i9_porc_aumento_3"]);
            }
            if (productOpportunityWin.Attributes.ContainsKey("i9_porc_aumento_4"))
            {
                this.i9_porc_aumento_4 = GetValueAttribute(productOpportunityWin["i9_porc_aumento_4"]);
            }
            if (productOpportunityWin.Attributes.ContainsKey("i9_porc_max_desconto"))
            {
                this.i9_porc_max_desconto = GetValueAttribute(productOpportunityWin["i9_porc_max_desconto"]);
            }
            if (productOpportunityWin.Attributes.ContainsKey("i9_porcentagem_desconto"))
            {
                this.i9_porcentagem_desconto = GetValueAttribute(productOpportunityWin["i9_porcentagem_desconto"]);
            }
            if (productOpportunityWin.Attributes.ContainsKey("i9_qtd_funcionario"))
            {
                this.i9_qtd_funcionario = GetValueAttribute(productOpportunityWin["i9_qtd_funcionario"]);
            }
            if (productOpportunityWin.Attributes.ContainsKey("i9_qtd_modalidade1"))
            {
                this.i9_qtd_modalidade1 = GetValueAttribute(productOpportunityWin["i9_qtd_modalidade1"]);
            }
            if (productOpportunityWin.Attributes.ContainsKey("i9_qtd_modalidade2"))
            {
                this.i9_qtd_modalidade2 = GetValueAttribute(productOpportunityWin["i9_qtd_modalidade2"]);
            }
            if (productOpportunityWin.Attributes.ContainsKey("i9_qtd_modalidade3"))
            {
                this.i9_qtd_modalidade3 = GetValueAttribute(productOpportunityWin["i9_qtd_modalidade3"]);
            }
            if (productOpportunityWin.Attributes.ContainsKey("i9_qtd_modalidade4"))
            {
                this.i9_qtd_modalidade4 = GetValueAttribute(productOpportunityWin["i9_qtd_modalidade4"]);
            }
            if (productOpportunityWin.Attributes.ContainsKey("i9_qtd_modulos"))
            {
                this.i9_qtd_modulos = GetValueAttribute(productOpportunityWin["i9_qtd_modulos"]);
            }
            if (productOpportunityWin.Attributes.ContainsKey("i9_qtd_usuario"))
            {
                this.i9_qtd_usuario = GetValueAttribute(productOpportunityWin["i9_qtd_usuario"]);
            }
            if (productOpportunityWin.Attributes.ContainsKey("i9_recrut_selecao"))
            {
                this.i9_recrut_selecao = GetValueAttribute(productOpportunityWin["i9_recrut_selecao"]);
            }
            if (productOpportunityWin.Attributes.ContainsKey("i9_sesmt"))
            {
                this.i9_sesmt = GetValueAttribute(productOpportunityWin["i9_sesmt"]);
            }
            if (productOpportunityWin.Attributes.ContainsKey("i9_tab_ajuste_func_1"))
            {
                this.i9_tab_ajuste_func_1 = GetValueAttribute(productOpportunityWin["i9_tab_ajuste_func_1"]);
            }
            if (productOpportunityWin.Attributes.ContainsKey("i9_tab_ajuste_func_2"))
            {
                this.i9_tab_ajuste_func_2 = GetValueAttribute(productOpportunityWin["i9_tab_ajuste_func_2"]);
            }
            if (productOpportunityWin.Attributes.ContainsKey("i9_tab_ajuste_func_3"))
            {
                this.i9_tab_ajuste_func_3 = GetValueAttribute(productOpportunityWin["i9_tab_ajuste_func_3"]);
            }
            if (productOpportunityWin.Attributes.ContainsKey("i9_tab_ajuste_func_4"))
            {
                this.i9_tab_ajuste_func_4 = GetValueAttribute(productOpportunityWin["i9_tab_ajuste_func_4"]);
            }
            if (productOpportunityWin.Attributes.ContainsKey("i9_tab_ajuste_usuario_1"))
            {
                this.i9_tab_ajuste_usuario_1 = GetValueAttribute(productOpportunityWin["i9_tab_ajuste_usuario_1"]);
            }
            if (productOpportunityWin.Attributes.ContainsKey("i9_tab_ajuste_usuario_2"))
            {
                this.i9_tab_ajuste_usuario_2 = GetValueAttribute(productOpportunityWin["i9_tab_ajuste_usuario_2"]);
            }
            if (productOpportunityWin.Attributes.ContainsKey("i9_tab_ajuste_usuario_3"))
            {
                this.i9_tab_ajuste_usuario_3 = GetValueAttribute(productOpportunityWin["i9_tab_ajuste_usuario_3"]);
            }
            if (productOpportunityWin.Attributes.ContainsKey("i9_tab_ajuste_usuario_4"))
            {
                this.i9_tab_ajuste_usuario_4 = GetValueAttribute(productOpportunityWin["i9_tab_ajuste_usuario_4"]);
            }
            if (productOpportunityWin.Attributes.ContainsKey("i9_tabela_preco"))
            {
                this.i9_tabela_preco = GetValueAttribute(productOpportunityWin["i9_tabela_preco"]);
            }
            if (productOpportunityWin.Attributes.ContainsKey("i9_trein_desenvolvimento"))
            {
                this.i9_trein_desenvolvimento = GetValueAttribute(productOpportunityWin["i9_trein_desenvolvimento"]);
            }
            if (productOpportunityWin.Attributes.ContainsKey("i9_unidade_negocio"))
            {
                this.i9_unidade_negocio = GetValueAttribute(productOpportunityWin["i9_unidade_negocio"]);
            }
            if (productOpportunityWin.Attributes.ContainsKey("i9_valor_com_desconto1"))
            {
                this.i9_valor_com_desconto1 = GetValueAttribute(productOpportunityWin["i9_valor_com_desconto1"]);
            }
            if (productOpportunityWin.Attributes.ContainsKey("i9_valor_com_desconto1_base"))
            {
                this.i9_valor_com_desconto1_base = GetValueAttribute(productOpportunityWin["i9_valor_com_desconto1_base"]);
            }
            if (productOpportunityWin.Attributes.ContainsKey("i9_valor_com_desconto2"))
            {
                this.i9_valor_com_desconto2 = GetValueAttribute(productOpportunityWin["i9_valor_com_desconto2"]);
            }
            if (productOpportunityWin.Attributes.ContainsKey("i9_valor_com_desconto2_base"))
            {
                this.i9_valor_com_desconto2_base = GetValueAttribute(productOpportunityWin["i9_valor_com_desconto2_base"]);
            }
            if (productOpportunityWin.Attributes.ContainsKey("i9_valor_com_desconto3"))
            {
                this.i9_valor_com_desconto3 = GetValueAttribute(productOpportunityWin["i9_valor_com_desconto3"]);
            }
            if (productOpportunityWin.Attributes.ContainsKey("i9_valor_com_desconto3_base"))
            {
                this.i9_valor_com_desconto3_base = GetValueAttribute(productOpportunityWin["i9_valor_com_desconto3_base"]);
            }
            if (productOpportunityWin.Attributes.ContainsKey("i9_valor_com_desconto4"))
            {
                this.i9_valor_com_desconto4 = GetValueAttribute(productOpportunityWin["i9_valor_com_desconto4"]);
            }
            if (productOpportunityWin.Attributes.ContainsKey("i9_valor_com_desconto4_base"))
            {
                this.i9_valor_com_desconto4_base = GetValueAttribute(productOpportunityWin["i9_valor_com_desconto4_base"]);
            }
            if (productOpportunityWin.Attributes.ContainsKey("i9_valor1"))
            {
                this.i9_valor1 = GetValueAttribute(productOpportunityWin["i9_valor1"]);
            }
            if (productOpportunityWin.Attributes.ContainsKey("i9_valor1_base"))
            {
                this.i9_valor1_base = GetValueAttribute(productOpportunityWin["i9_valor1_base"]);
            }
            if (productOpportunityWin.Attributes.ContainsKey("i9_valor2"))
            {
                this.i9_valor2 = GetValueAttribute(productOpportunityWin["i9_valor2"]);
            }
            if (productOpportunityWin.Attributes.ContainsKey("i9_valor2_base"))
            {
                this.i9_valor2_base = GetValueAttribute(productOpportunityWin["i9_valor2_base"]);
            }
            if (productOpportunityWin.Attributes.ContainsKey("i9_valor3"))
            {
                this.i9_valor3 = GetValueAttribute(productOpportunityWin["i9_valor3"]);
            }
            if (productOpportunityWin.Attributes.ContainsKey("i9_valor3_base"))
            {
                this.i9_valor3_base = GetValueAttribute(productOpportunityWin["i9_valor3_base"]);
            }
            if (productOpportunityWin.Attributes.ContainsKey("i9_valor4"))
            {
                this.i9_valor4 = GetValueAttribute(productOpportunityWin["i9_valor4"]);
            }
            if (productOpportunityWin.Attributes.ContainsKey("i9_valor4_base"))
            {
                this.i9_valor4_base = GetValueAttribute(productOpportunityWin["i9_valor4_base"]);
            }
            if (productOpportunityWin.Attributes.ContainsKey("i9_visualizar_ajustes"))
            {
                this.i9_visualizar_ajustes = GetValueAttribute(productOpportunityWin["i9_visualizar_ajustes"]);
            }
            if (productOpportunityWin.Attributes.ContainsKey("importsequencenumber"))
            {
                this.importsequencenumber = GetValueAttribute(productOpportunityWin["importsequencenumber"]);
            }
            if (productOpportunityWin.Attributes.ContainsKey("ispriceoverridden"))
            {
                this.ispriceoverridden = GetValueAttribute(productOpportunityWin["ispriceoverridden"]);
            }
            if (productOpportunityWin.Attributes.ContainsKey("isproductoverridden"))
            {
                this.isproductoverridden = GetValueAttribute(productOpportunityWin["isproductoverridden"]);
            }
            if (productOpportunityWin.Attributes.ContainsKey("lineitemnumber"))
            {
                this.lineitemnumber = GetValueAttribute(productOpportunityWin["lineitemnumber"]);
            }
            if (productOpportunityWin.Attributes.ContainsKey("manualdiscountamount"))
            {
                this.manualdiscountamount = GetValueAttribute(productOpportunityWin["manualdiscountamount"]);
            }
            if (productOpportunityWin.Attributes.ContainsKey("manualdiscountamount_base"))
            {
                this.manualdiscountamount_base = GetValueAttribute(productOpportunityWin["manualdiscountamount_base"]);
            }
            if (productOpportunityWin.Attributes.ContainsKey("modifiedby"))
            {
                this.modifiedby = GetValueAttribute(productOpportunityWin["modifiedby"]);
            }
            if (productOpportunityWin.Attributes.ContainsKey("modifiedon"))
            {
                this.modifiedon = GetValueAttribute(productOpportunityWin["modifiedon"]);
            }
            if (productOpportunityWin.Attributes.ContainsKey("modifiedonbehalfby"))
            {
                this.modifiedonbehalfby = GetValueAttribute(productOpportunityWin["modifiedonbehalfby"]);
            }
            if (productOpportunityWin.Attributes.ContainsKey("new_produtodaoportunidadeid"))
            {
                this.new_produtodaoportunidadeid = GetValueAttribute(productOpportunityWin["new_produtodaoportunidadeid"]);
            }
            if (productOpportunityWin.Attributes.ContainsKey("opportunityid"))
            {
                this.opportunityid = GetValueAttribute(productOpportunityWin["opportunityid"]);
            }
            if (productOpportunityWin.Attributes.ContainsKey("opportunityproductid"))
            {
                this.opportunityproductid = GetValueAttribute(productOpportunityWin["opportunityproductid"]);
            }
            if (productOpportunityWin.Attributes.ContainsKey("opportunitystatecode"))
            {
                this.opportunitystatecode = GetValueAttribute(productOpportunityWin["opportunitystatecode"]);
            }
            if (productOpportunityWin.Attributes.ContainsKey("overriddencreatedon"))
            {
                this.overriddencreatedon = GetValueAttribute(productOpportunityWin["overriddencreatedon"]);
            }
            if (productOpportunityWin.Attributes.ContainsKey("ownerid"))
            {
                this.ownerid = GetValueAttribute(productOpportunityWin["ownerid"]);
            }
            if (productOpportunityWin.Attributes.ContainsKey("owningbusinessunit"))
            {
                this.owningbusinessunit = GetValueAttribute(productOpportunityWin["owningbusinessunit"]);
            }
            if (productOpportunityWin.Attributes.ContainsKey("owninguser"))
            {
                this.owninguser = GetValueAttribute(productOpportunityWin["owninguser"]);
            }
            if (productOpportunityWin.Attributes.ContainsKey("parentbundleid"))
            {
                this.parentbundleid = GetValueAttribute(productOpportunityWin["parentbundleid"]);
            }
            if (productOpportunityWin.Attributes.ContainsKey("priceperunit"))
            {
                this.priceperunit = GetValueAttribute(productOpportunityWin["priceperunit"]);
            }
            if (productOpportunityWin.Attributes.ContainsKey("priceperunit_base"))
            {
                this.priceperunit_base = GetValueAttribute(productOpportunityWin["priceperunit_base"]);
            }
            if (productOpportunityWin.Attributes.ContainsKey("pricingerrorcode"))
            {
                this.pricingerrorcode = GetValueAttribute(productOpportunityWin["pricingerrorcode"]);
            }
            if (productOpportunityWin.Attributes.ContainsKey("productassociationid"))
            {
                this.productassociationid = GetValueAttribute(productOpportunityWin["productassociationid"]);
            }
            if (productOpportunityWin.Attributes.ContainsKey("productdescription"))
            {
                this.productdescription = GetValueAttribute(productOpportunityWin["productdescription"]);
            }
            if (productOpportunityWin.Attributes.ContainsKey("productid"))
            {
                this.productid = GetValueAttribute(productOpportunityWin["productid"]);
            }
            if (productOpportunityWin.Attributes.ContainsKey("producttypecode"))
            {
                this.producttypecode = GetValueAttribute(productOpportunityWin["producttypecode"]);
            }
            if (productOpportunityWin.Attributes.ContainsKey("propertyconfigurationstatus"))
            {
                this.propertyconfigurationstatus = GetValueAttribute(productOpportunityWin["propertyconfigurationstatus"]);
            }
            if (productOpportunityWin.Attributes.ContainsKey("quantity"))
            {
                this.quantity = GetValueAttribute(productOpportunityWin["quantity"]);
            }
            if (productOpportunityWin.Attributes.ContainsKey("sequencenumber"))
            {
                this.sequencenumber = GetValueAttribute(productOpportunityWin["sequencenumber"]);
            }
            if (productOpportunityWin.Attributes.ContainsKey("tax"))
            {
                this.tax = GetValueAttribute(productOpportunityWin["tax"]);
            }
            if (productOpportunityWin.Attributes.ContainsKey("tax_base"))
            {
                this.tax_base = GetValueAttribute(productOpportunityWin["tax_base"]);
            }
            if (productOpportunityWin.Attributes.ContainsKey("timezoneruleversionnumber"))
            {
                this.timezoneruleversionnumber = GetValueAttribute(productOpportunityWin["timezoneruleversionnumber"]);
            }
            if (productOpportunityWin.Attributes.ContainsKey("transactioncurrencyid"))
            {
                this.transactioncurrencyid = GetValueAttribute(productOpportunityWin["transactioncurrencyid"]);
            }
            if (productOpportunityWin.Attributes.ContainsKey("uomid"))
            {
                this.uomid = GetValueAttribute(productOpportunityWin["uomid"]);
            }
            if (productOpportunityWin.Attributes.ContainsKey("utcconversiontimezonecode"))
            {
                this.utcconversiontimezonecode = GetValueAttribute(productOpportunityWin["utcconversiontimezonecode"]);
            }
            if (productOpportunityWin.Attributes.ContainsKey("versionnumber"))
            {
                this.versionnumber = GetValueAttribute(productOpportunityWin["versionnumber"]);
            }
            if (productOpportunityWin.Attributes.ContainsKey("volumediscountamount"))
            {
                this.volumediscountamount = GetValueAttribute(productOpportunityWin["volumediscountamount"]);
            }
            if (productOpportunityWin.Attributes.ContainsKey("volumediscountamount_base"))
            {
                this.volumediscountamount_base = GetValueAttribute(productOpportunityWin["volumediscountamount_base"]);
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
