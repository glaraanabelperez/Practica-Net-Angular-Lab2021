export interface ABMInterface<T>{

    GetAll(): T[];

    GetById(id:string) :T;

    GetById( id:number) :T;

    Delete( id : string ):string;

    Delete(id: number):string;

    Insert(obj : T):string;

    Update(obj : T):string;

}

