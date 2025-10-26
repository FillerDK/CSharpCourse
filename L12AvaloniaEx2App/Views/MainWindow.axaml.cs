using System;
using System.Linq;
using Avalonia.Controls;
using Avalonia.Interactivity;

namespace L12AvaloniaEx2App.Views;

public partial class MainWindow : Window
{
    public MainWindow()
    {
        InitializeComponent();
    }

    private void Button_OnClick(object? sender, RoutedEventArgs e)
    {
        var button = ((Button)sender);
        var targetRow = Grid.GetRow(button);
        var grid = this.FindControl<Grid>("Grid");

        var controlsInRow = grid.Children
            .Where(child => Grid.GetRow(child) == targetRow)
            .ToList();

        var leftOfButton = (TextBlock)controlsInRow[0];
        var rightOfButton = (TextBlock)controlsInRow[2];
        
        // Swift left to right and reverse
        (leftOfButton.Text, rightOfButton.Text) = (rightOfButton.Text, leftOfButton.Text);
    }
}