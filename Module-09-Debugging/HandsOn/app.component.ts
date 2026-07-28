import { Component } from '@angular/core';

@Component({
  selector: 'app-root',
  templateUrl: './app.component.html'
})
export class AppComponent {

  title = 'Angular Debug Demo';

  count = 0;

  increment() {
    this.count++;
    console.log("Current Count :", this.count);
  }

}
