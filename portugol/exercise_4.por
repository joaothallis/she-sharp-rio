programa {
    funcao inicio() {
        cadeia salesman_name
        inteiro salary
        inteiro amount_of_sales_in_the_month
        
        inteiro percentage_of_sales_comission
        inteiro sales_comission
        
        leia(salesman_name)
        leia(salary)
        leia(amount_of_sales_in_the_month)
        
        percentage_of_sales_comission = 15
        
        sales_comission = 15 * amount_of_sales_in_the_month / 100
        
        escreva("Name: ", salesman_name)
        escreva("\n")
        escreva("Fixed salary: ", salary)
        escreva("\n")
        escreva("Final salary (salary with comission): ", salary + sales_comission)
    }
}