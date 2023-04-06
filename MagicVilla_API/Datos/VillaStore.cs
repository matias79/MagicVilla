﻿using MagicVilla_API.Modelos.DTO;

namespace MagicVilla_API.Datos
{
    public static class VillaStore
    {
        public static List<VillaDto> villaList = new List<VillaDto>
        {
            new VillaDto {Id=1, 
                Nombre="vista al mar",
                Ocupantes=3, 
                MetrosCuadrados=50,
                Amenidad="xx", 
                Tarifa=3000, 
                ImagenUrl="string1" },
            new VillaDto {Id=2,Nombre="vista a piscina", Ocupantes=4, MetrosCuadrados=80}
        };
    }
}
