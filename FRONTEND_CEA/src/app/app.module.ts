import { NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';

import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';
import { ReactiveFormsModule } from '@angular/forms';
import { HttpClientModule } from '@angular/common/http';
// import { CookieService } from 'ngx-cookie-service';
import { AccesoModule } from './modules/acceso/acceso.module';
import { LogoutModule } from './modules/logout/logout.module';
import { HomeModule } from './modules/home/home.module';



@NgModule({
  declarations: [
    AppComponent,
  ],
  imports: [

    AccesoModule,
    LogoutModule,
    BrowserModule,
    AppRoutingModule,
    ReactiveFormsModule,
    HttpClientModule,
    AccesoModule,
    HomeModule,
    
  ],
  providers: [],
  bootstrap: [AppComponent]
})
export class AppModule { }
