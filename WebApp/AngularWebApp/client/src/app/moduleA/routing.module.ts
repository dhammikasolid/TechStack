import { NgModule } from "@angular/core";
import { RouterModule, Routes } from "@angular/router";

import { ContainerComponent } from "./components/container.component";
import { ContainerComponent as A1ContainerComponent } from "./moduleA1/components/container.component";
import { ContainerComponent as A11ContainerComponent } from "./moduleA1/moduleA11/components/container.component";

const routes: Routes = [
  {
    path: "a",
    component: ContainerComponent,
    children: [
      //{ path: "", redirectTo: "a1", pathMatch: "full" },
      {
        path: "a1",
        component: A1ContainerComponent,
        children: [
          { path: "a11", component: A11ContainerComponent}
        ]
      }
    ]
  }
];

@NgModule({
    imports: [
        RouterModule.forChild(routes)
    ]
})
export class RoutingModule { }
