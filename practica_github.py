billetes = [100,200,500,1000]
Bancos = (["FDP INVERSMENTS",20000],["Otro",10000])

pase= None
def desglose_FDP_INVERSMENTS():
  global pase,billetes_de_1000,billetes_de_500,billetes_de_200,billetes_de_100
  print("\n-----------------------------------------------\n")
  print("\nHas seleccionado el banco", Bancos[0][0])
  print("  (El limite de retiro 20,000)\n")
  monto = int(input("Ingrese el monto a retirar: "))
  if monto <= Bancos[0][1]:
    if monto % billetes[3] ==0 or monto % billetes[0] == 0:
      if monto >= 19000 and monto <20000:
        billetes_de_1000=(monto-monto%billetes[3])//billetes[3]
        billetes_de_1000 -=1
        monto = monto - 18000
      elif monto == 20000:
        billetes_de_1000=(monto-monto%billetes[3])//billetes[3]
        billetes_de_1000 -=2
        monto = monto - 18000
      else: 
        billetes_de_1000=(monto-monto%billetes[3])//billetes[3]
        monto = monto%1000
      billetes_de_500 = (monto - monto%billetes[2])//billetes[2]
      monto = monto%500
      billetes_de_200 = (monto - monto%billetes[1])//billetes[1]
      monto = monto%200
      billetes_de_100 = (monto - monto%billetes[0])//billetes[0]
    else: 
      pase = 0
      if pase == 0:
        print("El monto ingresado no puede ser dispensado, ingrese una centena o millar")
  else:
    pase = 1  
    if pase == 1:
      print("Has exedido el limite de transacción")
      
  
  
    
    

def desglose_Otros():
  global x,billetes_de_1000,billetes_de_500,billetes_de_200,billetes_de_100
  print("\n-----------------------------------------------\n")
  print("\nHas seleccionado un banco Ajeno (El limite de retiro 10,000)\n")
  monto = int(input("Ingrese el monto a retirar: "))
  if monto <= Bancos[1][1]:
    if monto % billetes[3] ==0 or monto % billetes[0] == 0:
    
      billetes_de_1000=(monto-monto%billetes[3])//billetes[3]
      monto = monto%1000
      billetes_de_500 = (monto - monto%billetes[2])//billetes[2]
      monto = monto%500
      billetes_de_200 = (monto - monto%billetes[1])//billetes[1]
      monto = monto%200
      billetes_de_100 = (monto - monto%billetes[0])//billetes[0]
    else: 
      pase = 0
      if pase == 0:
        print("El monto ingresado no puede ser dispensado, ingrese una centena o millar")
  else:
    pase = 1  
    if pase == 1:
      print("Has exedido el limite de transacción")
  
    

def mostrar_retiro():
    global billetes_de_1000,billetes_de_500,billetes_de_200,billetes_de_100
    print ('\nValor de billetes de 1000: ', repr (billetes_de_1000))
    print ('Valor de billetes de 500: ', repr (billetes_de_500))
    print ('Valor de billetes de 200: ', repr (billetes_de_200))
    print ('Valor de billetes de 100: ', repr (billetes_de_100))
    
def salir():
  print("Has cancelado la solicitud")

def programa():
  #Mensaje de Inicio
  print("\n-----------------------------------------------\n")
  print("\nBenvenido al cajero del Banco FDP INVERSMENT\n")
  print("1. FDP INVERSMENT\n"
        "2. Otro\n"
        "3. Cancelar\n")
        
        
  select_banco = int(input("Seleccione el Banco que utiliza: "))
  
  while True:
    if select_banco == 1:
      desglose_FDP_INVERSMENTS()
      if pase == 0 or pase == 1:
        break
      else:
        mostrar_retiro()
      break
    elif select_banco == 2:
      desglose_Otros()
      if pase == 0 or pase == 1:
        break
      else:
        mostrar_retiro()
      break
    elif select_banco == 3:
      salir()
      break
    elif select_banco != 1 and select_banco != 2 and select_banco !=3:  
      print("No has elegido ninguna de las opciones")
      programa()
      break
  

programa()
  
     
      
      

  