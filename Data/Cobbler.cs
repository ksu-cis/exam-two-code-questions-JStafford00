using System;
using System.Collections.Generic;
using System.ComponentModel;

namespace ExamTwoCodeQuestions.Data
{
    public class Cobbler : IOrderItem, INotifyPropertyChanged
    {

        public event  PropertyChangedEventHandler PropertyChanged;
        private FruitFilling fruit;
        private bool withIceCream = true;
        private bool blueBerry = true;
        private bool cherry = false;
        private bool peach = false;

        /// <summary>
        /// The fruit used in the cobbler
        /// </summary>
        public FruitFilling Fruit
        {
            get
            {
                return fruit;
            }

            set
            {
                fruit = value;
                NotifyOfPropertyChange("Fruit");
            }
        }

        /// <summary>
        /// Getter/setter for blueBerry
        /// </summary>
        public bool BlueBerry
        {
            get
            {
                return blueBerry;
            }

            set
            {
                blueBerry = value;
            }
        }

        /// <summary>
        /// Getter/setter for cherry
        /// </summary>
        public bool Cherry
        {
            get
            {
                return cherry;
            }

            set
            {
                cherry = value;
            }
        }

        /// <summary>
        /// Getter/setter for peach
        /// </summary>
        public bool Peach
        {
            get
            {
                return peach;
            }

            set
            {
                peach = value;
            }
        }

        /// <summary>
        /// If the cobbler is served with ice cream
        /// </summary>
        public bool WithIceCream
        {
            get
            {
                return withIceCream;
            }

            set
            {
                withIceCream = value;
                NotifyOfPropertyChange("WithIceCream");
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Price"));
            }
        }

        /// <summary>
        /// Gets the price of the Cobbler
        /// </summary>
        public double Price
        {
            get
            {
                if (WithIceCream) return 5.32;
                else return 4.25;
            }
        }

        /// <summary>
        /// Gets any special instructions for preparing this dessert
        /// </summary>
        public List<string> SpecialInstructions
        {
            get
            {
                if(WithIceCream) { return new List<string>(); }
                else { return new List<string>() { "Hold Ice Cream" }; }
            }
        }

        /// <summary>
        /// Handles the property change events.
        /// </summary>
        /// <param name="s"></param>
        public void NotifyOfPropertyChange(string s)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(s));
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("SpecialInstructions"));
        }
    }
}
