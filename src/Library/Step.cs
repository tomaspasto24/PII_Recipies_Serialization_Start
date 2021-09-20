//-------------------------------------------------------------------------------
// <copyright file="Step.cs" company="Universidad Católica del Uruguay">
// Copyright (c) Programación II. Derechos reservados.
// </copyright>
//-------------------------------------------------------------------------------

using System.Text.Json;
using System.Text.Json.Serialization;

namespace Recipies
{
    public class Step : IJsonConvertible
    {
        [JsonConstructor]
        public Step(Product input, double quantity, Equipment equipment, int time)
        {
            this.Quantity = quantity;
            this.Input = input;
            this.Time = time;
            this.Equipment = equipment;
        }

        public Step(string json)
        {
            this.LoadFromJson(json);
        }

        public void LoadFromJson(string json)
        {
            this.Quantity = JsonSerializer.Deserialize<Step>(json). Quantity;
            this.Time = JsonSerializer.Deserialize<Step>(json).Time;
            this.Input = JsonSerializer.Deserialize<Step>(json).Input;
            this.Equipment = JsonSerializer.Deserialize<Step>(json).Equipment;
        }

        public string ConvertToJson()
        {
            return JsonSerializer.Serialize(this);
        }

        public Product Input { get; set; }

        public double Quantity { get; set; }

        public int Time { get; set; }

        public Equipment Equipment { get; set; }
    }
}