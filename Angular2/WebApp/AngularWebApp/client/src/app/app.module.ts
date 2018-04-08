// Framework/Vendor core modules
import { NgModule } from "@angular/core";
import { RouterModule } from "@angular/router"

// App core modules
import { CoreComponentsModule } from "./core/components/core-components.module";
// App core routing module
import { AppRoutingModule } from "./app.routing.module";
// App root component
import { AppComponent } from "./app.component";

//Level 1 feature modules
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
      AppRoutingModule
  ],
  bootstrap: [AppComponent]
})
export class AppModule { }
