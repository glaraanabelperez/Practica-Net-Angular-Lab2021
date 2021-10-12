import { BrowserModule } from '@angular/platform-browser';
import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';


import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';

import { HeaderComponent } from './shared/header/header.component';
import { AppNorthwindModule } from './northwind/app.northwind-module';
// import { AppComponentMorty } from './apiMorty/app.componenteMorty';
import { AppMortyModule } from './apiMorty/app.morty-module';

const routes: Routes = [
  {path: '', redirectTo: 'northwind', pathMatch:'full'},
  // {path: 'apiMorty', component: AppComponentMorty},

];

@NgModule({
  declarations: [
    AppComponent,
    HeaderComponent,
    // AppComponentMorty
  ],

  imports: [
    BrowserModule,
    AppRoutingModule,
    AppNorthwindModule,
    AppMortyModule,
    RouterModule.forRoot(routes),
  ],

  providers: [],
  // HttpClientModule
  bootstrap: [AppComponent]

})
export class AppModule { }
