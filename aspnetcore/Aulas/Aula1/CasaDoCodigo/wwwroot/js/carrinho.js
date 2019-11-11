class Carrinho {
    clickIncremento(btn) {
        let data = this.getData(btn);
        data.Quantidade++;
        this.postQuantidade(data);
    }

    clickDecremento(btn) {
        let data = this.getData(btn);
        data.Quantidade--;
        this.postQuantidade(data);
    }

    updateQuantidade(input) {
        let data = this.getData(input);
        this.postQuantidade(data);            
    }
    getData(elemento) {
        var linhadoItem = $(elemento).parents('[item-id]');
        var itemId = $(linhadoItem).attr('item-id');
        var novaQtde = $(linhadoItem).find('input').val();
        return {
            Id: itemId,
            Quantidade: novaQtde
        }

    }

    postQuantidade(data) {
        $.ajax({
            url: '/pedido/updatequantidade',
            type: 'POST',
            contentType: 'application/json',
            data: JSON.stringify(data)
        })
    }
}

carrinho = new Carrinho()