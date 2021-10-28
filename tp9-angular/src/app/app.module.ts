import { BrowserModule } from '@angular/platform-browser';
import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { BrowserAnimationsModule } from '@angular/platform-browser/animations';

import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';

import { HeaderComponent } from './shared/header/header.component';
import { AppNorthwindModule } from './northwind/northwind.module';
import { AppMortyModule } from './apiMorty/morty.module';



const routes: Routes = [

];

@NgModule({
  declarations: [
    AppComponent,
    HeaderComponent,
  ],

  imports: [
    BrowserModule,
    AppRoutingModule,
    BrowserAnimationsModule,
    AppNorthwindModule,
    AppMortyModule,
    RouterModule.forRoot(routes),
  ],

  providers: [],
  // HttpClientModule
  bootstrap: [AppComponent]

})
export class AppModule { }
