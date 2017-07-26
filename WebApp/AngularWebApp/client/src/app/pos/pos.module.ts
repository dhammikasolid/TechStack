import { NgModule } from '@angular/core';

import { PosComponent } from './pos.component';
import { PosFacilityComponent } from './pos-facility.component';

@NgModule({
    declarations: [
        PosComponent,
        PosFacilityComponent
    ],
    exports: [PosComponent],
    imports: [],
    providers: [],
})
export class PosModule { }