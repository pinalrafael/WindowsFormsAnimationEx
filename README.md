# WindowsFormsAnimation
-----

[NuGet Packages](https://www.nuget.org/packages/WindowsFormsAnimation/)
<br/>
.NET Framework 4.7.2

# A DLL
-----

A biblioteca é grátis para uso comercial ou não comercial.
<br/>
Animações para Windows Forms.
<br/>
As animações podem ser usadas de forma independente ou dependente do compomente.

# COMPATIVEL
-----
1. System.Windows.Forms.Panel

# USANDO NO COMPONENTE
-----

1. Instale a biblioteca pelo pacote NuGet Packages;
2. Crie o componente Panel como WFAPanel;
```cs
WindowsFormsAnimation.Controls.WFAPanel();
```
3. Para usar a animação de exibição uso o Show;
```cs
panel1.Show(new WindowsFormsAnimation.Classes.Config(){ Delay = 1, Finish = 100, Value = 1 }, Animation.SLIDE);
```
4. Para usar a animação de saída uso o Hide;
```cs
panel1.Hide(new WindowsFormsAnimation.Classes.Config(){ Delay = 1, Finish = 0, Value = 1 }, Animation.SLIDE);
```

# USANDO INDEPENDENTE
-----

1. Instale a biblioteca pelo pacote NuGet Packages;
2. Inicie o objeto WFAPanel;
```cs
WindowsFormsAnimation.Independents.WFAPanel WFAPanel1 = new WindowsFormsAnimation.Independents.WFAPanel();
```
3. Para usar a animação de exibição uso o Show;
```cs
WFAPanel1.Show(new WindowsFormsAnimation.Classes.Config(){ Delay = 1, Finish = 100, Value = 1 }, Animation.SLIDE, panel2);
```
4. Para usar a animação de saída uso o Hide;
```cs
WFAPanel1.Hide(new WindowsFormsAnimation.Classes.Config(){ Delay = 1, Finish = 0, Value = 1 }, Animation.SLIDE, panel2);
```

# EVENTOS
-----

1. AnimationStateResponse é executado toda vez que a animação é finalizada;
```cs
private void Panel1_AnimationStateResponse(object sender, EventArgs e)
{
	EventStateArgs ev = (EventStateArgs)e;
}
```
2. InAnimation é executado durante a animação;
```cs
private void Panel1_InAnimation(object sender, EventArgs e)
{
	EventStateArgs ev = (EventStateArgs)e;
}
```

# SUPORTE
-----

[**Siga-me**](https://github.com/pinalrafael?tab=followers) para minhas próximas criações