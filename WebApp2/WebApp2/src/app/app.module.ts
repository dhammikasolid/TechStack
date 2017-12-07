import { BrowserModule } from '@angular/platform-browser';
import { NgModule } from '@angular/core';
import { RouterModule } from '@angular/router';

import { AppComponent } from './app.component';
import { NavMainComponent } from './shared/nav-main/nav-main.component';

import { RoutingModule } from './routing/routing.module';

@NgModule({
  declarations: [
    AppComponent,
    NavMainComponent
  ],
  imports: [
    BrowserModule,
    RoutingModule,
    RouterModule
  ],
  providers: [],
  bootstrap: [AppComponent]
})
export class AppModule { }
