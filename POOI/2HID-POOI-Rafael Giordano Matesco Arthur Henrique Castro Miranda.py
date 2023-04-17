# 2HID-POOI
# Rafael Giordano Matesco
# Arthur Henrique Castro Miranda

resp = 's'
potencia_m2 = 0
total_lampadas = 0
# classe: 1=15W, 2=18W, 3=20W


while resp == 's':
    print('========================================')
    nome_comodo = input('Digite o nome do cômodo: ')
    largura = float(input('Digite a largura do cômodo: '))
    comprimento = float(input('Digite o comprimento do cômodo: '))
    print('\n')
    if nome_comodo == 'quarto' or nome_comodo == 'sala de tv':
        potencia_m2 = 15
        area = largura * comprimento
        qntd_lampadas = (potencia_m2 * area) / 60
        if qntd_lampadas < 1:
            qntd_lampadas = 1
        print(f'Nome do cômodo: {nome_comodo}')
        print(f'Área do cômodo {area}m²')
        print(f'Potência de iluminação: {potencia_m2}W/m²')
        print(f'Quantidade de lâmpadas: {int(qntd_lampadas)}')
        print('\n')
        total_lampadas += qntd_lampadas
        resp = input('Deseja testar outro quarto? s/n: ')
    elif nome_comodo == 'sala' or nome_comodo == 'cozinha' or nome_comodo == 'varanda':
        potencia_m2 = 18
        area = largura * comprimento
        qntd_lampadas = (potencia_m2 * area) / 60
        if qntd_lampadas < 1:
            qntd_lampadas = 1
        print(f'Nome do cômodo: {nome_comodo}')
        print(f'Área do cômodo {area}m²')
        print(f'Potência de iluminação: {potencia_m2}W/m²')
        print(f'Quantidade de lâmpadas: {int(qntd_lampadas)}')
        print('\n')
        total_lampadas += qntd_lampadas
        resp = input('Deseja testar outro quarto? s/n: ')
    elif nome_comodo == 'escritorio' or nome_comodo == 'banheiro':
        potencia_m2 = 20
        area = largura * comprimento
        qntd_lampadas = (potencia_m2 * area) / 60
        if qntd_lampadas < 1:
            qntd_lampadas = 1
        print(f'Nome do cômodo: {nome_comodo}')
        print(f'Área do cômodo {area}m²')
        print(f'Potência de iluminação: {potencia_m2}W/m²')
        print(f'Quantidade de lâmpadas: {int(qntd_lampadas)}')
        print('\n')
        total_lampadas += qntd_lampadas
        resp = input('Deseja testar outro quarto? s/n: ')
    else:
        print('Digite um nome de cômodo válido ')

    if resp != 's' and resp != 'n':
        while resp != 's' and resp != 'n':
            print('Digite uma resposta valida')
            resp = input('Deseja testar outro quarto? s/n: ')

print('========================================')
print('Para toda a residência')
print(f'Total de lâmpadas: {int(total_lampadas-1)}')
print(f'Total de potência utilizada pelas lâmpadas: {total_lampadas*60}W')

