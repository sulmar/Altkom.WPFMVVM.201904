# Altkom.WPFMVVM.201904

# Klasy WPF

- **Object** - klasa bazowa dla wszystkich klas .NET
- **DispatcherObject** - klasa bazowa dla dowolnego obiektu, który chce być dostępny tylko w wątku, który go utworzył. Dispatcher utrzymuje priorytetową kolejkę elementów pracy dla określonego wątku. Większość klas WPF wywodzi się z DispatcherObject i dlatego z natury jest niebezpieczna dla wątków.
- **DependencyObject** - klasa bazowa, która zapewnia obsługę Dependency Properties. Definiuje metody _GetValue_ i _SetValue_
- **Freezable** - klasa bazowa dla obiektów, które mogą być "zamrożone" do stanu tylko-do-odczytu ze względu na wydajność. Takie obiekty, po zamrożoneniu, mogą być bezpiecznie współdzielone przez wiele wątków, w przeciwieństwie do DispatcherObjects. Zamrożone obiekty nigdy nie mogą zostać odmrożone, ale sklonowane do niezamrożonych kopii.
- **Visual** - klasa bazowa abstrakcyjna, dla wszystkich obiektów, które mają własną reprezentację wizualną. Jego główną rolą jest zapewnienie wsparcia renderowania.
- **UIElement** - klasa podstawowa dla wszystkich obiektów wizualnych z obsługą Routed Events, Command Binding, Layout i fokus.
- **ContentElement** - klasa bazowa podobna do UIElement, ale dla fragmentów treści, które nie mają własnego zachowania renderowania. Zamiast tego obiekty ContentElements są hostowane w klasie pochodnej Visual, która ma być renderowana na ekranie.
- **FrameworkElement** - klasa bazowa, która dodaje obsługę stylów, powiązań danych, zasobów i kilku typowych mechanizmów do sterowania opartego na systemie Windows, takich jak podpowiedzi i menu kontekstowe.
- **Shape** - klasa bazowa dla kształtów takich jak Ellipse, Polygon i Rectangle.
- **Panel** - klasa bazowa do pozycjonowania elementów 
- **Control** - klasa bazowa, która dodaje do FrameworkElement właściwości Foreground, Background, FontSize i Template
- **ContentControl** - klasa bazowa dla kontrolek, które mogą mieć tylko jeden element podrzędny. Element podrzędny może być dowolnym elementem od ciągu znaków do panelu układu z kombinacją innych elementów sterujących i kształtów.
- **ItemsControl** - klasa bazowa dla kontrolek, których można użyć do prezentacji kolekcji elementów, takich jak elementy ListBox i TreeView.

# Hierarchia klas

| Nazwa                | Threading | DP | Rendering | Hit Testing | Layout | Input | Focus | Events | Styles | Data Binding | Resources | Animation | Template |
| -------------------- | ----------|----|---------- | ----------- | ------ | ----- | ----- | ------ | ------ | ------------ |  -------- | -------- | -------- | 
| DispatcherObject     | x |   |
| DependendencyObject  | x | x | 
| Visual               | x | x | x | x |
| UIElement            | x | x | x | x | x | x | x | x | 
| FrameworkElement     | x | x | x | x | x | x | x | x | x | x | x | x | 
| Control     | x | x | x | x | x | x | x | x | x | x | x | x | x |
| ContentControl     | x | x | x | x | x | x | x | x | x | x | x | x | x |
| ItemsControl     | x | x | x | x | x | x | x | x | x | x | x | x | x |

### Fody


1. Dodaj biblioteki
~~~
PM> Install-Package Fody
PM> Install-Package PropertyChanged.Fody
~~~

2. Utwórz plik FodyWeavers.xml
~~~ xml
<?xml version="1.0" encoding="utf-8" ?>
<Weavers>
  <PropertyChanged/>
</Weavers>
~~~

 Wszystkie klasy, które implementują INotifyPropertyChanged będą miały wstrzyknięty kod do powiadamiania.


https://github.com/Fody/PropertyChanged


