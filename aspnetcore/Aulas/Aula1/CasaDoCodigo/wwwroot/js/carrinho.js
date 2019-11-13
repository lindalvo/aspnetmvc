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

        let token = $('[name=__RequestVerificationToken]').val();

        let headers = {};
        headers['RequestVerificationToken'] = token;

        $.ajax({
            url: '/pedido/updatequantidade',
            type: 'POST',
            contentType: 'application/json',
            data: JSON.stringify(data),
            headers: headers
        }).done(function (response) {
            let itemPedido = response.itemPedido;
            let linhadoItem = $('[item-id=' + itemPedido.id + ']');
            linhadoItem.find('input').val(itemPedido.quantidade);
            linhadoItem.find('[subtotal]').html((itemPedido.subtotal).duasCasas());
            let carrinhoViewModel = response.carrinhoViewModel;
            $('[numero-itens]').html('Total: ' + carrinhoViewModel.itens.length + ' itens')
            $('[total]').html((carrinhoViewModel.total).duasCasas());

            if (itemPedido.quantidade == 0) {
                linhadoItem.remove();
            }
            //debugger;
            });
    }
}

carrinho = new Carrinho()

Number.prototype.duasCasas = function () {
    return this.toFixed(2).replace('.', ',');
}