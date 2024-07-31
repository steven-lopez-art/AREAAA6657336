using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;

namespace AREAAA6657336.ViewModels
{
    public partial class MainViewModels : ObservableObject
    {
        [ObservableProperty]
        public double lado1;

        [ObservableProperty]
        public double lado2;

        [ObservableProperty]
        public double lado3;

        [ObservableProperty]
        public double superficie;

        [ObservableProperty]
        public double resultado;


        [RelayCommand]
        public void Calcular()
        {
            double Superficie = (Lado1 + Lado2 + Lado3) / 2;

            double area = (Superficie * (Superficie - Lado1) * (Superficie - Lado2) * (Superficie - Lado3));

            double area2 = Math.Sqrt(area);

            Resultado = area2;
        }
    }
}
