import { Injectable } from "@angular/core";
import { HttpClient } from "@angular/common/http";
import { Morty } from "../models/Morty";
import { Observable } from "rxjs";
import { environment } from "src/environments/environment";

//duda

@Injectable({
    providedIn:'root'
})

export class ServiceMorty{

    endpointMorty: string='Morty';

    constructor(private http:HttpClient){}

    GetAll(): Observable<Array<Morty>>{

        let url=environment.northwindApi + this.endpointMorty;
        return this.http.get<Array<Morty>>(url);
    }

}
