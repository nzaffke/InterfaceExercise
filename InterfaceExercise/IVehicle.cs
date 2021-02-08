﻿using System;
using System.Collections.Generic;
using System.Text;

namespace InterfaceExercise
{
    interface IVehicle
    {
        public double EngineSize { get; set; }

        public string Make { get; set; }

        public string Modle { get; set; }

        public int SeatCount { get; set; }
        public bool HasChangedGears { get; set; }

        public void Drive();
        public void Reverse();
        public void Park();
        public void ChangeGears(bool isChanged);

    }
}
