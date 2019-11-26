using System.Collections;
using System;
using System.Collections.Generic;
using UnityEngine;

public class Armas : IEquatable<Armas>{
    public int id { get; set; }
    public string nombre_arma { get; set; }
    public string nombre_bala { get; set; }
    public float velocidad { get; set; }
    //public int tiempo { get; set; }
    public int danio { get; set; }
    void Awake(){
        ///DontDestroyOnLoad(gameObject);
    }
    // Start is called before the first frame update
    void Start(){
        
    }

    // Update is called once per frame
        void Update(){
        
    }

    public override int GetHashCode(){
            return id;
        }

    public override bool Equals(object obj){
            if (obj == null) return false;
            Armas objAsPart = obj as Armas;
            if (objAsPart == null) return false;
            else return Equals(objAsPart);
    }
    public bool Equals(Armas other){
            if (other == null) return false;
            return (this.nombre_arma.Equals(other.nombre_arma));
    }
    public override string ToString(){
            return "arma: " + nombre_arma + "\nbala: " + nombre_bala+"\nvelocidad: "+velocidad+"\ndanio: "+danio;
    }
}