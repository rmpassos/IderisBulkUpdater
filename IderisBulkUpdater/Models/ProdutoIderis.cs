using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace IderisBulkUpdater.Models
{
    public class ProdutoIderis
    {

        public int Id { get; set; }
        public string Sku { get; set; }
        public bool ShouldSerializeSku()
        {
            return false;
        }
        public string Titulo { get; set; }
        public bool ShouldSerializeTitulo()
        {
            return false;
        }
        public string DescricaoLonga { get; set; }
        public bool ShouldSerializeDescricaoLonga()
        {
            return false;
        }

        /// No GET do produto, o JSON vem como marcaID, porem no PUT é necessário enviar como marcaIdIderis, então foi feito esse esquema para contornar o problema.
        public int MarcaIdIderis { get { return MarcaId; } }

        public int MarcaId { get; set; }
        /// No GET do produto, o JSON vem como marcaID, porem no PUT é necessário enviar como marcaIdIderis, então foi feito esse esquema para contornar o problema.
        public bool ShouldSerializeMarcaId()
        {
            return false;
        }
        public string Marca { get; set; }
        public bool ShouldSerializeMarca()
        {
            return false;
        }
        public int DepartamentoId { get; set; }
        public bool ShouldSerializeDepartamentoId()
        {
            return false;
        }
        public string Departamento { get; set; }
        public bool ShouldSerializeDepartamento()
        {
            return false;
        }
        public int CategoriaId { get; set; }
        public bool ShouldSerializeCategoriaId()
        {
            return false;
        }
        public string Categoria { get; set; }
        public bool ShouldSerializeCategoria()
        {
            return false;
        }
        public int SubCategoriaId { get; set; }
        public bool ShouldSerializeSubCategoriaId()
        {
            return false;
        }
        public string SubCategoria { get; set; }
        public bool ShouldSerializeSubCategoria()
        {
            return false;
        }
        public string Modelo { get; set; }
        public bool ShouldSerializeModelo()
        {
            return false;
        }
        public string Garantia { get; set; }
        public bool ShouldSerializeGarantia()
        {
            return false;
        }
        public decimal? Peso { get; set; }
        public decimal? Comprimento { get; set; }
        public decimal? Largura { get; set; }
        public decimal? Altura { get; set; }
        public decimal? PesoEmbalagem { get; set; }
        public decimal? ComprimentoEmbalagem { get; set; }
        public decimal? LarguraEmbalagem { get; set; }
        public decimal? AlturaEmbalagem { get; set; }
        public int? NcmId { get; set; }
        public bool ShouldSerializeNcmId()
        {
            return false;
        }
        public string Ncm { get; set; }
        public bool ShouldSerializeNcm()
        {
            return false;
        }
        public int? ProdutoOrigemId { get; set; }
        public bool ShouldSerializeProdutoOrigemId()
        {
            return false;
        }
        public string ProdutoOrigem { get; set; }
        public bool ShouldSerializeProdutoOrigem()
        {
            return false;
        }
        public string Cest { get; set; }
        public bool ShouldSerializeCest()
        {
            return false;
        }
        public string Ean { get; set; }
        public bool ShouldSerializeEan()
        {
            return false;
        }
        public int TipoProdutoId { get; set; }
        public bool ShouldSerializeTipoProdutoId()
        {
            return false;
        }
        public string TipoProduto { get; set; }
        public bool ShouldSerializeTipoProduto()
        {
            return false;
        }
        public string CaminhoImagem { get; set; }
        public bool ShouldSerializeCaminhoImagem()
        {
            return false;
        }
        public int EstoquePrincipalId { get; set; }
        public bool ShouldSerializeEstoquePrincipalId()
        {
            return false;
        }
        public int QuantidadeEstoquePrincipal { get; set; }
        public bool ShouldSerializeQuantidadeEstoquePrincipal()
        {
            return false;
        }
        public object QuantidadeEstoquePrincipalReserva { get; set; }
        public bool ShouldSerializeQuantidadeEstoquePrincipalReserva()
        {
            return false;
        }
        public double ValorCusto { get; set; }
        public bool ShouldSerializeValorCusto()
        {
            return false;
        }
        public double ValorVenda { get; set; }
        public bool ShouldSerializeValorVenda()
        {
            return false;
        }
        public DateTime UltimaAlteracaoPreco { get; set; }
        public bool ShouldSerializeUltimaAlteracaoPreco()
        {
            return false;
        }
        public List<Variacao> Variacao { get; set; }
        public bool ShouldSerializeVariacao()
        {
            return false;
        }
        public List<object> ProdutoComposto { get; set; }
        public bool ShouldSerializeProdutoComposto()
        {
            return false;
        }
    }
}
