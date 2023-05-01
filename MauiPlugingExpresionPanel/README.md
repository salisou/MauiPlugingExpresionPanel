[.NET MAUI] Presentazione di come utilizzare Expander

![delivery_android](https://github.com/salisou/MauiPlugingExpresionPanel/blob/master/Cattura.PNG?raw=true)
![delivery_android2](https://github.com/salisou/MauiPlugingExpresionPanel/blob/master/Cattura2.PNG?raw=true)
![delivery_android2](https://user-images.githubusercontent.com/73097560/115834477-dbab4500-a447-11eb-908a-139a6edaec5c.gif)

Questo progetto illustra come usare Expander con .NET MAUI.

Gli espansori risparmiano spazio sullo schermo e aiutano gli utenti ad accedere ai contenuti di interesse.

Si prega di fare riferimento a questo articolo.

# 1 Come usare Expander?

Questo Expander non è registrato come controllo standard in .NET MAUI. Pertanto, per gestire Expander, è necessario installare una libreria denominata " CommunityToolkit.Maui " da NuGet.

Questa libreria è una raccolta di elementi utili durante lo sviluppo di app con .NET MAUI. È caratterizzato dall'avere funzioni generiche come comportamenti e convertitori.

# Installa libreria
![delivery_android2](https://user-images.githubusercontent.com/73097560/115834477-dbab4500-a447-11eb-908a-139a6edaec5c.gif)

Apri il progetto in Visual Studio 2022 e seleziona Strumenti -> Gestione pacchetti NuGet -> Gestisci pacchetti NuGet per soluzione dalla barra dei menu.

Inserisci "CommunityToolkit.Maui" nel campo di ricerca e installa "CommunityToolkit.Maui" dall'elenco dei risultati della ricerca. (A partire da aprile 2023, la versione è 5.0.0)


![delivery_android](https://github.com/salisou/MauiPlugingExpresionPanel/blob/master/Cattura3.PNG?raw=true)

Al termine dell'installazione viene visualizzato un ReadMe.txt. Questo file descrive come utilizzare la libreria.

![delivery_android](https://github.com/salisou/MauiPlugingExpresionPanel/blob/master/Cattura4.PNG?raw=true)

# Inizializzazione della libreria

![delivery_android2](https://user-images.githubusercontent.com/73097560/115834477-dbab4500-a447-11eb-908a-139a6edaec5c.gif)

Effettuare le impostazioni per l'utilizzo della libreria.

Apri MainProgram.cs e aggiungi un'istruzione using all'inizio del file.

    using CommunityToolkit.Maui;

Successivamente, aggiungi il processo di inizializzazione di CommunityToolkit.Maui al processo di avvio. (Aggiunto alla riga 8 del codice seguente)

    public static class MauiProgram
    {
    public static MauiApp CreateMauiApp()
    {
        var builder = MauiApp.CreateBuilder();
        builder
            .UseMauiApp<App>()
            .UseMauiCommunityToolkit()
            .ConfigureFonts(fonts =>
            {
                fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
                fonts.AddFont("OpenSans-Semibold.ttf", "OpenSansSemibold");
            });

        return builder.Build();
        }
    }

Ora siamo pronti per usare l'Expander.

![delivery_android2](https://user-images.githubusercontent.com/73097560/115834477-dbab4500-a447-11eb-908a-139a6edaec5c.gif)

# Come usare Expander

Apri MainPage.xaml e aggiungi lo spazio dei nomi CommunityToolkit.Maui ai tuoi spazi dei nomi XAML.

    xmlns:toolkit="http://schemas.microsoft.com/dotnet/2022/maui/toolkit"

Per impostazione predefinita, il contenuto è in uno stato compresso, ma impostando la proprietà IsExpanded (tipo bool) su true, il contenuto verrà visualizzato in uno stato espanso.

## Codice d'esempio
![delivery_android2](https://user-images.githubusercontent.com/73097560/115834477-dbab4500-a447-11eb-908a-139a6edaec5c.gif)

Introdurrò il codice di esempio di Expander. Il codice XAML è il seguente.

    <?xml version="1.0" encoding="utf-8" ?>
        <ContentPage xmlns="http://schemas.microsoft.com/dotnet/2021/maui"
                     xmlns:x="http://schemas.microsoft.com/winfx/2009/xaml" 
                     xmlns:toolkit="http://schemas.microsoft.com/dotnet/2022/maui/toolkit"
                     x:Class="MauiPlugingExpresionPanel.MainPage">

    <ScrollView>
        <VerticalStackLayout
            Spacing="25"
            Padding="30,0"
            VerticalOptions="Center">

          
            <toolkit:Expander x:Name="MyExpander" IsExpanded="False">
                <!--  Intestazione del expander -->
                <toolkit:Expander.Header>
                    <Grid  ColumnDefinitions="*" HeightRequest="45">
                        <Grid.Resources>
                            <Style TargetType="Label">
                                <Setter Property="FontSize" Value="18" />
                                <Setter Property="FontAttributes" Value="Bold" />
                                <Setter Property="VerticalTextAlignment" Value="Center" />
                            </Style>
                        </Grid.Resources>
                        <Border Padding="5" BackgroundColor="#F1F1F1">
                            <StackLayout Orientation="Horizontal">
                                <Label  Text="Profilo Programmatore" />
                                <Image HeightRequest="25" WidthRequest="25" HorizontalOptions="EndAndExpand">
                                    <Image.Triggers>
                                        <DataTrigger TargetType="Image" 
                                                         Binding="{Binding Source={x:Reference MyExpander}, Path=IsExpanded}" 
                                                         Value="True">
                                            <Setter Property="Source" Value="up_arrow"/>
                                        </DataTrigger>
                                        <DataTrigger TargetType="Image" 
                                                         Binding="{Binding Source={x:Reference MyExpander}, Path=IsExpanded}" 
                                                         Value="False">
                                            <Setter Property="Source" Value="down_arrow"/>
                                        </DataTrigger>
                                    </Image.Triggers>
                                </Image>
                            </StackLayout>
                            <Border.StrokeShape>
                                <RoundRectangle CornerRadius="16"/>
                            </Border.StrokeShape>
                        </Border>
                    </Grid>
                </toolkit:Expander.Header>
                <!--  Contenuto expander  -->
                <toolkit:Expander.Content>
                    <Frame Margin="5"  BorderColor="Gray"  CornerRadius="16">
                        <Grid ColumnDefinitions="60, *">
                            <Image MaximumHeightRequest="50" MaximumWidthRequest="50" Source="man.png" />
                            <VerticalStackLayout Grid.Column="1" Margin="10,0,0,0">
                                <Label FontSize="20" Text="Moussa " TextColor="#086bed" />
                                <Label Text="Full Stack .Net Developer" />
                                <Label FontSize="12" Text="E-mail : xxx.xxxxx@gmail.com" />
                            </VerticalStackLayout>
                        </Grid>
                    </Frame>
                </toolkit:Expander.Content>
            </toolkit:Expander>
        </VerticalStackLayout>
    </ScrollView>

  </ContentPage>
  
<h3 align="left">Support Me:</h3>
<p><a aling="center" href="https://www.buymeacoffee.com/salisoumouW"> 
<img aling="center" src="https://cdn.buymeacoffee.com/buttons/v2/default-yellow.png" height="50" width="210" alt="Moussa" /></a><a href="https://ko-fi.com/salisoumoussa"> 
<img aling="center" src="https://cdn.ko-fi.com/cdn/kofi3.png?v=3" height="50" width="210" alt="saliou" /></a>
</p>