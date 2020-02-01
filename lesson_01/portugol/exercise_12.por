programa {
    funcao inicio() {
        inteiro factory_car_cost
        inteiro taxes
        inteiro distributor_part
        
        leia(factory_car_cost)
        
        
        taxes = 45 * factory_car_cost / 100
        distributor_part = 28 * (factory_car_cost + taxes) / 100
        
        
        escreva(factory_car_cost + taxes + distributor_part)
    }
}