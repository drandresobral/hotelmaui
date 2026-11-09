# Hotel Aurora — Agenda 13 | .NET 10 MAUI

Projeto acadêmico de André Alves Sobral (2026), desenvolvido com C# e XAML para **Windows e Android**.

## Requisitos
- Windows 10 (build 19041+) ou Windows 11 para a versão desktop.
- Visual Studio com suporte ao **.NET 10** e à carga de trabalho **.NET MAUI**; SDK .NET 10.
- Para Android: SDK Android, emulador ou dispositivo conectado.
- Para Windows: componentes de desenvolvimento Windows App SDK/WinUI instalados pelo Visual Studio.

## Executar no Windows
1. Abra `AppHotelAgenda13.csproj` no Visual Studio no Windows.
2. Restaure os pacotes NuGet e selecione o destino **Windows Machine**.
3. Execute com **F5**. A aplicação abre como janela desktop, redimensionável.
4. Acesse a aba **Sobre** para visualizar **André Alves Sobral — 2026**.

## Executar no Android
Selecione um emulador/dispositivo Android como destino e execute com F5.

## Compilar pelo terminal (Windows)
```powershell
dotnet workload install maui
dotnet restore -p:TargetFramework=net10.0-windows10.0.19041.0
dotnet build -f net10.0-windows10.0.19041.0 -p:RuntimeIdentifierOverride=win10-x64
```
A compilação e execução dependem dos componentes MAUI/Windows SDK instalados. `WindowsPackageType=None` configura o modo sem empacotamento MSIX, adequado para depuração desktop; isso **não** gera automaticamente um instalador independente.

## Funcionalidades
- Reservar: nome, acomodação (`Picker`), hóspedes (`Stepper`), entrada/saída (`DatePicker`).
- Resumo: total ilustrativo de diárias e `BindingContext`.
- Sobre: desenvolvedor **André Alves Sobral**, ano **2026**, versão **1.0**.
- Navegação com Shell e layouts com `ScrollView`, adaptáveis a janelas de diferentes tamanhos.

## Entrega
Execute no Windows ou Android, abra **Sobre** e capture uma imagem real da tela em funcionamento. Salve-a em `Entrega/Capturas/`, compacte as capturas separadamente e publique o código-fonte em um repositório GitHub próprio. Mockups não substituem evidências de execução.

**Observação:** este pacote não foi compilado nem executado aqui, pois o SDK .NET/ambiente Windows não está disponível. Valide no Visual Studio antes da entrega.

Referência didática: Agenda 13 e https://github.com/tiagotas/MauiAppHotel/tree/f4651e5172dedfceec4630538ffe4bf340bce128
