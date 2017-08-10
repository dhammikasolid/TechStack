import { BrowserModule } from '@angular/platform-browser';
import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router'

import { CoreComponentsModule } from './core/components/core-components.module';
import { RoutingModule } from './routing.module';
import { AppComponent } from './app.component';

import { Module as AModule } from './moduleA/module';
import { Module as BModule } from './moduleB/module';

@NgModule({
  declarations: [
      AppComponent,
  ],
  imports: [
      BrowserModule,
      RouterModule,
      CoreComponentsModule,
      AModule,
      BModule,
      RoutingModule,
  ],
  providers: [],
  bootstrap: [AppComponent]
})
export class AppModule { }
