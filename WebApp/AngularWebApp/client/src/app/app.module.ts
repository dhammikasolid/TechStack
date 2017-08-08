import { BrowserModule } from '@angular/platform-browser';
import { NgModule } from '@angular/core';

import { AppComponent } from './app.component';
import { Module as AModule} from './moduleA/module';
import { Module as BModule } from './moduleB/module';

let modb = require('./moduleB/module');

@NgModule({
  declarations: [
      AppComponent,
  ],
  imports: [
      BrowserModule,
      AModule,
      BModule
  ],
  providers: [],
  bootstrap: [AppComponent]
})
export class AppModule { }
