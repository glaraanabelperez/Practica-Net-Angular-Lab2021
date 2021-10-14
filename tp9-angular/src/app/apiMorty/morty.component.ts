import { Component, OnInit } from '@angular/core';
import { Morty } from './models/Morty';
import { ServiceMorty } from './services/morty.service';

@Component({
  selector: 'app-Morty',
  templateUrl: './morty.component.html',
  styleUrls: ['./morty.component.scss']
})
export class AppComponentMorty  {

  characters: Array<Morty>=[];

  constructor(private _serviceMorty: ServiceMorty){
    this.GetAllCharacters();

  }

  GetAllCharacters(){
    this._serviceMorty.GetAll().subscribe(
      res=>{
        if(res!=null){
          this.characters=res;
        }
      },
      err => {
        alert("Oops!!, Hubo un error para traer los datos")
      })
  }


}
