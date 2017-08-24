import { NgModule } from "@angular/core";
import { RouterModule } from "@angular/router"

import { CoreComponentsModule } from "./core/components/core-components.module";
import { RoutingModule } from "./routing.module";
import { AppComponent } from "./app.component";

import { Module as AModule } from "./moduleA/module";
import { Module as BModule } from "./moduleB/module";

@NgModule({
  declarations: [
      AppComponent
  ],
  imports: [
      RouterModule,
      CoreComponentsModule,
      AModule,
      BModule,
      RoutingModule
  ],
  bootstrap: [AppComponent]
})
export class AppModule { }
