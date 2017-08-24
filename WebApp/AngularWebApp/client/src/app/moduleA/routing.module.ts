import { NgModule } from "@angular/core";
import { RouterModule, Routes } from "@angular/router";

import { ContainerComponent } from "./components/container.component";
import { ContainerComponent as ContainerA1} from "./moduleA1/components/container.component";

const routes: Routes = [
  {
    path: "a",
    component: ContainerComponent,
    children: [
      { path: "", redirectTo: "a1", pathMatch: "full" },
      { path: "a1", component: ContainerA1 }
    ]
  }
];

@NgModule({
    imports: [
        RouterModule.forChild(routes)
    ]
})
export class RoutingModule { }
