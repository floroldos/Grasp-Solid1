using System;

namespace Full_GRASP_And_SOLID.Library
{
    public class Cost
    {
        public static double GetProductionCost(Step pasos)
        {
            double CostoInsumos = ((pasos.Input.UnitCost * pasos.Quantity) / 1000);
            double CostoEquipamiento = (pasos.Equipment.HourlyCost * (pasos.Time / 3600));
            double CostoTotal = (CostoInsumos + CostoEquipamiento);
            return CostoTotal;
        }
    }
}

/* En este caso utilicé el principio SRP, ya que todas las clases tienen una sola funcionalidad. 
Creé un método en una clase propia (que calcule solo el costo de producción) y luego lo utilicé en la clase Recipe en el momento de la impresión. 
Lo calcula allí directamente y lo imprime.*/