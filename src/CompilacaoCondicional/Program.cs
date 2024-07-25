
#if VersaoProfissional && VersaoTestes
#error O sistema não pode ser Profissional e de Testes ao mesmo tempo
#endif

#if VersaoProfissional
const bool PermitirIntegrações = true;
const bool PermitirSuporteTecnico = true;
#else
const bool PermitirIntegrações = false;
const bool PermitirSuporteTecnico = false;
#endif

Console.WriteLine($"Permitir Integrações: {PermitirIntegrações}");
Console.WriteLine($"Permitir Suporte Tecnico: {PermitirSuporteTecnico}");

#if DEBUG
Console.WriteLine($"Você está em debug.");
#else
Console.WriteLine($"Você está em release.");
#endif

#region Main

for (int i = 0; i < 10000; i++)
{
    #region Mostrar apenas os pares
    if (i % 2 == 0)
        Console.WriteLine($"é par {i}");
    #endregion
}
#endregion

Console.ReadLine();