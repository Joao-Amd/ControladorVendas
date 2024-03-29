﻿using ApiControladorVendas.Dominio.Fornecedores;
using ApiControladorVendas.Dominio.ItemVendas;

namespace ApiControladorVendas.Dominio.Itens
{
    public class Item
    {
        public Item(string descricao, decimal preco, int quantidade, Fornecedor fornecedor)
        {
            Descricao = descricao;
            Preco = preco;
            Quantidade = quantidade;
            IdFornecedor = fornecedor.Id;
            Fornecedor = fornecedor;
        }

        protected Item() { }

        public int Id { get; private set; }
        public string Descricao { get; private set; }
        public decimal Preco { get; private set; }
        public int Quantidade { get; private set; }
        public int IdFornecedor { get; private set; }

        //

        public virtual Fornecedor Fornecedor { get; private set; }
        public virtual ICollection<ItemVenda> ItensVenda { get; private set; }


    public static Item Novo(string descricao, decimal preco, int quantidade, Fornecedor fornecedor)
        {
            return new Item(descricao, preco, quantidade, fornecedor);
        }

        public void Alterar(string descricao, decimal preco, int quantidade, Fornecedor fornecedor)
        {
            Descricao = descricao;
            Preco = preco;
            Quantidade = quantidade;
            IdFornecedor = fornecedor.Id;
            Fornecedor = fornecedor;
        }
    }
}
