programa {
    funcao inicio() {
        inteiro cost_price
        inteiro sale_price
        inteiro percentage_for_the_sale_price
        
        leia(cost_price)
        leia(percentage_for_the_sale_price)
        
        sale_price = cost_price + (cost_price * percentage_for_the_sale_price / 100)
        
        escreva(sale_price)
    }
}