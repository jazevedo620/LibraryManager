# LibraryManager

![Screen upon startup](https://i.imgur.com/DcIdyZC.png)

Library Manager is a client database program designed to manage the issuance of books for a school library. With features like managing history, adding and removing items, and a system for reserving books for varying durations. The project as a whole is a component of a submission into the Future Business Leaders of America's *Coding & Programming* competition, the specific requirements for which were listed [on their website (archived)](https://web.archive.org/web/20180217192136im_/http://www.fbla-pbl.org:80/competitive-event/coding-programming/). A functioning copy is [availible here](https://drive.google.com/open?id=1AMA78FJQyUQVBUjYxqNNe8dfbLri5gqG) (runnable on the .NET runtime).

## Underlying Architecture

As part of the design guidelines, Library Manager is a Client database programmed designed to be connected to a centralized database server. Instead of locally serving the database

Internally, Library Managaer takes advantage of Microsoft's flagship .NET framework, Windows Presentation Foundation, or WPF. WPF works through two components: The design is programmed in **XAML**, or Extensible Application Markup Language (*different from XML*), while the behavior is programmed in **C#**. This seperation of *design* and *behavior* is key to the framework's architecture, as it allows for the adoption of the Model-View-ViewModel design paradigm as outlined below.
![MVVM](https://lh6.googleusercontent.com/Af-v-f6_zS01CwUnSnxriKNEmozAzd7ICQIRI1J_UmQiBbHA5w_V27PAWDLPXB3agclrRC_XtELotvG0LjmEKE9rEOKp4yzd33Se3j_A=s596)

## Documentation

Extensible documentation was developed via LaTeX in order to explain each feature of the program, and is availible as a [PDF document](https://drive.google.com/open?id=1rzvxD1XwVbWNX5nE0kkMXI031g4EwGW_).

## Design Process

A breif slideshow discussing the development of the project has been created, and is availible below.
<a href="https://docs.google.com/presentation/d/e/2PACX-1vTGNy98lkIgXEggQ311Q4-lEVoktZXNi6ZJbzeMykYx1stRzgmh1ap6npJRz_zBeCNXJ6MNUN8nVQ-w/pub?start=false&loop=false&delayms=3000" target="_blank"><img src="https://i.imgur.com/7RM6kRB.png" alt="slideshow" width="240" height="180" border="10" /></a>