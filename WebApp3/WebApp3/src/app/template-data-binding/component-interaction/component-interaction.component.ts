import {
  Component, Input, Output, EventEmitter,
  OnChanges, SimpleChanges, ViewChild
} from '@angular/core';

// Childs

@Component({
  selector: 'app-component-interaction-input-child',
  template: `
      <div *ngIf="prop">{{ prop }}</div>
      <div *ngIf="objectProp">{{ objectProp.prop1 }} {{ objectProp.prop2 }}</div>
      <div *ngIf="collection?.length > 0">
          <div *ngFor="let item of collection">{{ item.prop1 }} {{ item.prop2 }}</div>
      </div>
  `,
  styleUrls: ['./component-interaction.component.css']
})
export class ComponentInteractionComponentInputChild implements OnChanges {

  @Input() prop: string;
  @Input() objectProp: string;
  @Input() collection: string;

  ngOnChanges(changes: SimpleChanges) {
    console.log(changes);
  }
}

@Component({
  selector: 'app-component-interaction-twoway-child',
  template: `
      <button (click)="changeParentProp()">changeParentProp()</button>
      <button (click)="changeParentObjectProp()">changeParentObjectProp()</button>
      <button (click)="changeParentCollectionObject()">changeParentCollectionObject()</button>
  `,
  styleUrls: ['./component-interaction.component.css']
})
export class ComponentInteractionComponentTwowayChild {

  @Input() prop: string;
  @Output() propChange = new EventEmitter<string>();

  @Input() objectProp: { prop1: string, prop2: string };
  // [(objectProp)] binding
  @Output() objectPropChange = new EventEmitter<any>();

  @Input() collection: { prop1: string, prop2: string }[];
  //Custom Event
  @Output() collectionItemChange = new EventEmitter<any>();

  changeParentProp() {
    this.propChange.emit(this.prop + ' c');
  }

  changeParentObjectProp() {
    this.objectPropChange.emit({
      prop1: this.objectProp.prop1 + ' c'
    });
  }
}

@Component({
  selector: 'app-component-interaction-reference-child',
  template: `
      Child: {{ prop }}
  `,
  styleUrls: ['./component-interaction.component.css']
})
export class ComponentInteractionComponentReferenceChild {

  prop: string = 'c';

  changeProp(val) {
    this.prop = this.prop + val;
  }
}

@Component({
  selector: 'app-component-interaction-view-child',
  template: `
      Child: {{ prop }}
  `,
  styleUrls: ['./component-interaction.component.css']
})
export class ComponentInteractionComponentViewChild {

  prop: string = 'c';

  changeProp(val) {
    this.prop = this.prop + val;
  }
}


// Parent

@Component({
  selector: 'app-component-interaction',
  templateUrl: './component-interaction.component.html',
  styleUrls: ['./component-interaction.component.css']
})
export class ComponentInteractionComponent {

  // Parent Inputs

  prop = 'Prop';

  objectProp = {
    prop1: 'Prop 1',
    prop2: 'Prop 2',
  };

  collection = [
    { prop1: 'Prop 11', prop2: 'Prop 21' },
    { prop1: 'Prop 12', prop2: 'Prop 22' },
    { prop1: 'Prop 13', prop2: 'Prop 23' },
  ]

  changeProp() {
    this.prop = this.prop + ' p';
  }

  changeObjectProp() {
    this.objectProp.prop1 = this.objectProp.prop1 + ' p';
  }

  changeCollectionObject() {
    this.collection[1].prop1 = this.collection[1].prop1 + ' p';
  }

  // Template Reference Variable

  passToComponent(childRef: ComponentInteractionComponentReferenceChild) {
    // Access child data
    console.log(childRef);

    // Invoke child actions/events
    childRef.changeProp(' p');
  }

  passObjectToComponent(prop) {
    console.log(prop);
  }

  // @ViewChild injection

  @ViewChild(ComponentInteractionComponentViewChild)
  viewChild: ComponentInteractionComponentViewChild;

  viewChildAccess() {
    this.viewChild.changeProp(' p');
  }
}




