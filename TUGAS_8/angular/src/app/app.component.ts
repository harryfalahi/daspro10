import {
  Component
} from '@angular/core';

@Component({
  selector: 'app-root',
  templateUrl: './app.component.html'
})

export class AppComponent {
  pelajaran = 'Pemprograman Framework'

  GantiMatkul(){
    this.pelajaran = 'Pemprograman Visual'
  }
}
